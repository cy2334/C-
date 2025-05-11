namespace BuilderPatternDemo;

public class Computer
{
    public string CPU { get; set; }
    public string Memory { get; set; }
    public string HardDisk { get; set; }
    public string? GraphicsCard { get; set; }
    public string? Monitor {get; set;}

    public void DisplayConfiguration()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"内存: {Memory}");
        Console.WriteLine($"硬盘: {HardDisk}");
        Console.WriteLine($"显卡: {GraphicsCard ?? "无"}");
        Console.WriteLine($"显示器: {Monitor ?? "无"}");
        Console.WriteLine("-----------------------------");
    }
}