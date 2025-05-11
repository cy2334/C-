// See https://aka.ms/new-console-template for more information

using BuilderPatternDemo;

// 创建高配电脑建造者

var highEndBuilder = new HighEndComputerBuilder();
var director = new ComputerDirector(highEndBuilder);

// 构建标准办公电脑（高配版）
Computer officeComputer = director.BuildStandardOfficeComputer();
officeComputer.DisplayConfiguration();

// 构建游戏电脑（高配版）
Computer gamingComputer = director.BuildGamingComputer();
gamingComputer.DisplayConfiguration();

// 创建低配电脑建造者
var lowEndBuilder = new LowEndComputerBuilder();
director = new ComputerDirector(lowEndBuilder);

// 构建标准办公电脑（低配版）
Computer budgetComputer = director.BuildStandardOfficeComputer();
budgetComputer.DisplayConfiguration();


Console.WriteLine("Hello, World!");