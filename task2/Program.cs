Employee alice = new Employee("Alice", "manager");
Employee bob = new Employee("Bob", "engineer");
Console.WriteLine(SalaryCounter.Salary(alice));
Console.WriteLine(SalaryCounter.Salary(bob));
class Employee
{
    public string _name = "";
    public string _post = "";
    public Employee(string name, string post) {  _name = name; _post = post;}
}
class SalaryCounter
{
    static public int mrot = 20000;
    static public double Salary(Employee employee)
    {
        switch (employee._post) {
            case "engineer":
                return 4 * mrot;
            case "manager":
                return 4.5 * mrot;
            case "cleaner":
                return mrot;
            case "boss":
                return 20 * mrot;
            default: return 0;
        }
    }
}