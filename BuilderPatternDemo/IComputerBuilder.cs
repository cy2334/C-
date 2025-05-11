namespace BuilderPatternDemo;

public interface IComputerBuilder
{
    //必选组件
    void BuildCPU(string cpu);
    void BuildMemory(string memory);
    void BuildHardDisk(string disk);
    
    //可选组件
    void BuildGraphicsCard(string Card);
    void BuildMonitor(string monitor);
    
    //获取最终产品
    Computer GetComputer();
}