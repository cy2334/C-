namespace OOPDemo;

public class Animal
{
    private string _name;

    public string Name
    {
        get{return _name;}
        set{_name=value;}
    }

    public Animal(string name)
    {
        _name = name;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"动物发出声音");
    }
}