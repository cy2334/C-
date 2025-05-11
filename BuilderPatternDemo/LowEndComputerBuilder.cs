namespace BuilderPatternDemo;

public class LowEndComputerBuilder :IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU(string cpu)
    {
        _computer.CPU = $"基础款 {cpu}";
    }

    public void BuildMemory(string memory)
    {
        _computer.Memory = $"{memory} DDR4";
    }

    public void BuildHardDisk(string disk)
    {
        _computer.HardDisk = $"{disk} HDD";
    }

    public void BuildGraphicsCard(string card)
    {
        // 低配电脑不安装独立显卡
        _computer.GraphicsCard = "集成显卡";
    }

    public void BuildMonitor(string monitor)
    {
        _computer.Monitor = $"{monitor} 1080P";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}