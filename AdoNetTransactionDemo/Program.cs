// See https://aka.ms/new-console-template for more information


using AdoNetTransactionDemo;

string connectionString = "Server=CHINAMI-9AS5CS2;Database=TransactionDemo;User Id=sa;Password=123456;";
            
var dbHelper = new DatabaseHelper(connectionString);
if (dbHelper.TestConnection())
{
    Console.WriteLine("数据库连接成功！");
        
    try
    {
        // 从账户1转200到账户2
        dbHelper.TransferFunds(1, 2, 200m);
            
        // 尝试从账户1转2000到账户2（应该会失败）
        dbHelper.TransferFunds(1, 2, 2000m);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"发生错误: {ex.Message}");
    }
}
else
{
    Console.WriteLine("无法连接到数据库，请检查连接字符串。");
}
    
Console.WriteLine("按任意键退出...");
Console.ReadKey();
Console.WriteLine("Hello, World!");