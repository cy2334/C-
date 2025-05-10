namespace SingletonDemo;
//双重检测锁定
public class Logger2
{
    private static Logger2 _instance;
    private static readonly object _lock = new();
    private Logger2(){}

    public static Logger2 Instance
    {
        get
        {
            if (_instance == null)
            {
                lock(_lock)
                {
                    if (_instance == null)  // 第二次检查
                    {
                        _instance = new Logger2();
                    }
                }
            }
            return _instance;
        }
    }
    // 示例方法
    public void Log(string message)
    {
        Console.WriteLine($"[Log] {message}");
    }
}