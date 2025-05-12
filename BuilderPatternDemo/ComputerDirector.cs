namespace BuilderPatternDemo;

// public class ComputerDirector
// {
//     private  IComputerBuilder _builder;
//
//     public ComputerDirector(IComputerBuilder builder)
//     {
//         _builder = builder;
//     }
//     // 定义标准构建流程（例如：标准办公电脑）
//     public Computer BuildStandardOfficeComputer()
//     {
//         _builder.BuildCPU("Intel i5");
//         _builder.BuildMemory("16GB");
//         _builder.BuildHardDisk("512GB");
//         return _builder.GetComputer();
//     }
//     // 定义高级构建流程（例如：游戏电脑）
//     public Computer BuildGamingComputer()
//     {
//         _builder.BuildCPU("AMD Ryzen 9");
//         _builder.BuildMemory("32GB");
//         _builder.BuildHardDisk("1TB");
//         _builder.BuildGraphicsCard("NVIDIA");
//         _builder.BuildMonitor("ASUS");
//         return _builder.GetComputer();
//     }
// }