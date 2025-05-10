namespace OOPDemo;

public class Cat:Animal,IMovable
{
    //构造函数
    public Cat(string name):base(name){}
    public override void Speak()
    {
        Console.WriteLine($"{Name} Meow");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} 正在悄悄移动...");
    }
}

public class Dog : Animal
{
    public Dog(string name):base(name){}

    public override void Speak()
    {
        Console.WriteLine($"{Name} 说：汪汪！");
    }
}