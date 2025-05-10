namespace SingletonDemo;
//懒加载
public class Logger3
{
    private static readonly Lazy<Logger3> _lazyInstance  
        = new Lazy<Logger3>(() => new Logger3());
    public static Logger3 Instance => _lazyInstance .Value;
    private  Logger3(){}
    // 示例方法
    public void Log(string message)
    {
        Console.WriteLine($"[Log] {message}");
    }
}