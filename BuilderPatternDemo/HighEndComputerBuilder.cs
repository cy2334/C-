namespace BuilderPatternDemo;

public class HighEndComputerBuilder :IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU(string cpu)
    {
        _computer.CPU = $"高性能{cpu}";
    }

    public void BuildMemory(string memory)
    {
        _computer.Memory = $"{memory} DDR5";
    }

    public void BuildHardDisk(string disk)
    {
        _computer.HardDisk = $"{disk} SSD";
    }

    public void BuildGraphicsCard(string card)
    {
        _computer.GraphicsCard = $"{card} RTX 4090";
    }

    public void BuildMonitor(string monitor)
    {
        _computer.Monitor = $"{monitor} 4K 144Hz";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}