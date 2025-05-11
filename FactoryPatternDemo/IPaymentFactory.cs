namespace FactoryPatternDemo;
//抽象工厂接口
public interface IPaymentFactory
{
    IPayment CreatePayment();
}