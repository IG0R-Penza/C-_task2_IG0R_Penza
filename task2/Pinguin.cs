using System;
namespace Base;
public class Pinguin : Bird
{
    public Pinguin(string name) : base(name) { }
    public void Swim() { Console.WriteLine($"{_name} is swimming"); }
}