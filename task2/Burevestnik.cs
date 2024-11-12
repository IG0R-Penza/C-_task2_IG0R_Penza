using System;
namespace Base;
public class Burevestnik : Bird, IFlyer
{
    public Burevestnik(string name) : base(name) { }
    public void Fly(){ Console.WriteLine($"{_name} is flying"); }
}