// See https://aka.ms/new-console-template for more information

using SingletonDemo;

Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;

Console.WriteLine($"logger1和logger2是一个吗 {logger1 == logger2}");

logger1.Log("用户登录成功");
logger2.Log("订单已创建");

Console.WriteLine("Hello, World!");