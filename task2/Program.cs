using System.Net.Http.Headers;

{
    MFU mfu = new MFU("Brother");
    IPrinter printer = new Printer("HP");
    mfu.Scan();
    mfu.Print();
    printer.Print();
}

interface IPrinter
{
    public void Print() { Console.WriteLine("Printing..."); }
}
interface IScanner
{
    public void Scan(string name) { Console.WriteLine("Scanning..."); }
}
class MFU : IPrinter, IScanner
{
    private string _name = "";
    public MFU(string name) { _name = name; }
    public void Scan() { Console.WriteLine("Scanning..."); }
    public void Print() { Console.WriteLine("Printing..."); }
}
class Printer : IPrinter
{
    private string _name = "";
    public Printer(string name) { _name = name; }
}