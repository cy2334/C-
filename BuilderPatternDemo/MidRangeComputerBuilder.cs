namespace BuilderPatternDemo;

public class MidRangeComputerBuilder: IComputerBuilder
{
    private Computer _computer = new Computer();

    public IComputerBuilder  BuildCPU(string cpu)
    {
        _computer.CPU = $"中端 {cpu}";
        return this;
    }

    public IComputerBuilder  BuildMemory(string memory)
    {
        _computer.Memory = $"{memory} DDR4";
        return this;
    }

    public IComputerBuilder  BuildHardDisk(string disk)
    {
        _computer.HardDisk = $"{disk} NVMe SSD";
        return this;
    }

    public IComputerBuilder  BuildGraphicsCard(string card)
    {
        _computer.GraphicsCard = $"{card} RTX 3060";
        return this;
    }

    public IComputerBuilder  BuildMonitor(string monitor)
    {
        _computer.Monitor = $"{monitor} 2K 60Hz";
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
    
}