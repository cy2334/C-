namespace BuilderPatternDemo;

public class HighEndComputerBuilder :IComputerBuilder
{
    private Computer _computer = new Computer();

    public IComputerBuilder BuildCPU(string cpu)
    {
        _computer.CPU = $"高性能 {cpu}";
        return this;  // 返回自身以支持链式调用
    }

    public IComputerBuilder BuildMemory(string memory)
    {
        _computer.Memory = $"{memory} DDR5";
        return this;
    }

    public IComputerBuilder BuildHardDisk(string disk)
    {
        _computer.HardDisk = $"{disk} SSD";
        return this;
    }

    public IComputerBuilder BuildGraphicsCard(string card)
    {
        _computer.GraphicsCard = $"{card} RTX 4090";
        return this;
    }

    public IComputerBuilder BuildMonitor(string monitor)
    {
        _computer.Monitor = $"{monitor} 4K 144Hz";
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}