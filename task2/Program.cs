Bird filin = new Bird("Filin");
Bird pingiun = new Pinguin("Pin");
filin.Fly();
pingiun.Fly();
class Bird
{
    protected string _name = "";
    public Bird(string name) { _name = name; }
    public virtual void Fly() { Console.WriteLine($"{_name} is flying"); }
}
class Pinguin : Bird
{
    public Pinguin(string name) : base(name){}
    public override void Fly() { Console.WriteLine($"{_name} can't fly 'cause it's pinguin"); }
}