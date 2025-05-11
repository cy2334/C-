// See https://aka.ms/new-console-template for more information

using FactoryPatternDemo;

IPayment payment = PaymentFactory.CreatePayment("alipay");
payment.Pay(100.50m);

payment= PaymentFactory.CreatePayment("wechat");
payment.Pay(200.00m);
Console.WriteLine("Hello, World!");

IPaymentFactory factory = new AlipayFactory();
IPayment payment2 = factory.CreatePayment();
payment.Pay(100.50m);

factory = new WechatPayFactory();
payment2 = factory.CreatePayment();
payment2.Pay(200.00m);