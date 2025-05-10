namespace FactoryPatternDemo;
//简单工厂
public interface IPayment
{
    void Pay(decimal amount);
}

public class Alipay : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"支付宝：{amount}元");
    }
}

public class WechatPay : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"微信支付：{amount} 元");
    }
}