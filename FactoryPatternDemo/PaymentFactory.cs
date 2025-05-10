namespace FactoryPatternDemo;

public class PaymentFactory
{
    // 根据支付类型参数创建对象
    public static IPayment CreatePayment(string paymentType)
    {
        switch (paymentType.ToLower())
        {
            case "alipay":
                return new Alipay();
            case "wechat":
                return new WechatPay();
            default:
                throw new ArgumentException("不支持的支付方式");
        }
    } 
}