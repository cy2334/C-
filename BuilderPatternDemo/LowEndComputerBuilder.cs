namespace BuilderPatternDemo;

public class LowEndComputerBuilder :IComputerBuilder
{
    private Computer _computer = new Computer();

    public IComputerBuilder BuildCPU(string cpu)
    {
        _computer.CPU = $"基础款 {cpu}";
        return this;
    }

    public IComputerBuilder BuildMemory(string memory)
    {
        _computer.Memory = $"{memory} DDR4";
        return this;
    }

    public IComputerBuilder BuildHardDisk(string disk)
    {
        _computer.HardDisk = $"{disk} HDD";
        return this;
    }

    public IComputerBuilder BuildGraphicsCard(string card)
    {
        // 低配电脑不安装独立显卡
        _computer.GraphicsCard = "集成显卡";
        return this;
    }

    public IComputerBuilder BuildMonitor(string monitor)
    {
        _computer.Monitor = $"{monitor} 1080P";
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
    
}