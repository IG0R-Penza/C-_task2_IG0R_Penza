{
    Dog dog = new Dog("Sheepdog");
    Cat cat = new Cat("Scottish fold");
    dog.MakeSound();
    cat.MakeSound();
}

class Animal
{
    private string _name="";
    public string Name {
        get { return _name; }
        set { _name = value; }
    }
    public Animal(string name){Name = name;}
    public virtual void MakeSound() { Console.WriteLine($"{_name}: SOUND"); }
}

class Dog : Animal
{
    public Dog(string name) : base(name) {}
    public override void MakeSound() { Console.WriteLine($"{Name}: BARK!!!"); }
}
class Cat : Animal
{
    public Cat(string name) : base(name){}
    public override void MakeSound() { Console.WriteLine($"{Name}: Meow"); }
}