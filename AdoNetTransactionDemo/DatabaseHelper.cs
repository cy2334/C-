using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AdoNetTransactionDemo;

public class DatabaseHelper
{
    private readonly string _connectionString;

    public DatabaseHelper(string connectionString)
    {
        _connectionString = connectionString;
    }

    // 测试连接是否成功
    public bool TestConnection()
    {
        try
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"连接失败: {ex.Message}");
            return false;
        }
    }

    public void TransferFunds(int fromAccountId, int toAccountId, decimal amount)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    // 1. 检查转出账户余额（修正表名和参数）
                    var checkBalanceCmd = new SqlCommand(
                        "SELECT Balance FROM Accounts WHERE AccountId = @AccountId", // ✅ 修正表名和关键字
                        connection, transaction);
                    checkBalanceCmd.Parameters.AddWithValue("@AccountId", fromAccountId); // ✅ 使用转出账户ID

                    decimal currentBalance = (decimal)checkBalanceCmd.ExecuteScalar();

                    if (currentBalance < amount)
                    {
                        throw new Exception("转出账户余额不足");
                    }

                    // 2. 扣款操作（保持不变）
                    var debitCmd = new SqlCommand(
                        "UPDATE Accounts SET Balance = Balance - @Amount WHERE AccountId = @AccountId",
                        connection, transaction);
                    debitCmd.Parameters.AddWithValue("@AccountId", fromAccountId);
                    debitCmd.Parameters.AddWithValue("@Amount", amount);
                    int rowsAffected = debitCmd.ExecuteNonQuery();

                    if (rowsAffected != 1)
                    {
                        throw new Exception("扣款操作失败");
                    }

                    // 3. 存款操作（保持不变）
                    var creditCmd = new SqlCommand(
                        "UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountId = @AccountId",
                        connection, transaction);
                    creditCmd.Parameters.AddWithValue("@AccountId", toAccountId);
                    creditCmd.Parameters.AddWithValue("@Amount", amount);
                    rowsAffected = creditCmd.ExecuteNonQuery();

                    if (rowsAffected != 1)
                    {
                        throw new Exception("存款操作失败");
                    }

                    // 4. 提交事务
                    transaction.Commit();
                    Console.WriteLine($"成功从账户{fromAccountId}转账{amount}到账户{toAccountId}");
                }
                catch (Exception ex)
                {
                    // 回滚事务
                    transaction.Rollback();
                    Console.WriteLine($"转账失败: {ex.Message}");
                    throw;
                }
            }
        }
    }

    public void WithOutUsing(int fromAccountId, int toAccountId, decimal amount)
    {
        var connection = new SqlConnection(_connectionString);
        connection.Open();

        var transaction = connection.BeginTransaction();

        try
        {
            // 扣款操作（同时校验余额）
            var debitCmd = new SqlCommand(@"
        UPDATE Accounts 
        SET Balance = Balance - @Amount 
        WHERE AccountId = @FromId AND Balance >= @Amount", connection, transaction);
            debitCmd.Parameters.AddWithValue("@FromId", fromAccountId);
            debitCmd.Parameters.AddWithValue("@Amount", amount);

            if (debitCmd.ExecuteNonQuery() != 1)
                throw new Exception("转出账户余额不足或账户不存在");

            // 存款操作
            var creditCmd = new SqlCommand(@"
        UPDATE Accounts 
        SET Balance = Balance + @Amount 
        WHERE AccountId = @ToId", connection, transaction);
            creditCmd.Parameters.AddWithValue("@ToId", toAccountId);
            creditCmd.Parameters.AddWithValue("@Amount", amount);

            if (creditCmd.ExecuteNonQuery() != 1)
                throw new Exception("转入账户不存在");

            transaction.Commit();
            Console.WriteLine($"成功从账户{fromAccountId}转账{amount}到账户{toAccountId}");
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            Console.WriteLine($"转账失败: {ex.Message}");
            throw;
        }
        finally
        {
            connection.Close(); // 手动释放连接资源
        }
    }
}
