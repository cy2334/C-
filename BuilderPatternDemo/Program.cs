// See https://aka.ms/new-console-template for more information

using BuilderPatternDemo;

// // 创建高配电脑建造者
//
// var highEndBuilder = new HighEndComputerBuilder();
// var director = new ComputerDirector(highEndBuilder);
//
// // 构建标准办公电脑（高配版）
// Computer officeComputer = director.BuildStandardOfficeComputer();
// officeComputer.DisplayConfiguration();
//
// // 构建游戏电脑（高配版）
// Computer gamingComputer = director.BuildGamingComputer();
// gamingComputer.DisplayConfiguration();
//
// // 创建低配电脑建造者
// var lowEndBuilder = new LowEndComputerBuilder();
// director = new ComputerDirector(lowEndBuilder);
//
// // 构建标准办公电脑（低配版）
// Computer budgetComputer = director.BuildStandardOfficeComputer();
// budgetComputer.DisplayConfiguration();

var customComputer = new HighEndComputerBuilder()
    .BuildCPU("AMD Ryzen 7")
    .BuildMemory("32GB")
    .BuildHardDisk("2TB")
    .BuildGraphicsCard("NVIDIA")
    .BuildMonitor("LG Ultragear")
    .Build();

customComputer.DisplayConfiguration();

var minimalComputer = new MidRangeComputerBuilder()
    .BuildCPU("Intel i5")
    .BuildMemory("16GB")
    .BuildHardDisk("512GB")
    .Build();  // 不安装显卡和显示器

minimalComputer.DisplayConfiguration();

var mixedComputer = new LowEndComputerBuilder()
    .BuildCPU("Intel Celeron")
    .BuildMemory("8GB")
    .BuildHardDisk("256GB")
    .BuildMonitor("Dell 1080P")  // 低配但安装显示器
    .Build();

mixedComputer.DisplayConfiguration();
Console.WriteLine("Hello, World!");