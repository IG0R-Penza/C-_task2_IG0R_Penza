using System;
namespace Base;
public class Bird
{
    protected string _name = "";
    public Bird(string name) { _name = name; }
    public void Walk(){ Console.WriteLine($"{_name} is walking"); }
}