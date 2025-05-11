namespace FactoryPatternDemo;

public class AlipayFactory : IPaymentFactory
{
    public IPayment CreatePayment()
    {
        return new Alipay();
    }
}

public class WechatPayFactory : IPaymentFactory
{
    public IPayment CreatePayment()
    {
        return new WechatPay();
    }
}