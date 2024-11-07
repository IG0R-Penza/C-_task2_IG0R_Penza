{
    BankAccount bob = new BankAccount("Bob", 123);
    BankAccount alice = new BankAccount("Alice", 429);
    bob.deposit(123, 2134);
    bob.withdraw(789, 20);
    alice.withdraw(429, 20);
    bob.withdraw(123, 20);
}

class BankAccount
{
    private string _Name;
    private int _Password;
    private int _Balance = 0;

    public void deposit(int pass, int sum)
    {
        if (pass == this._Password)
        {
            this._Balance += sum;
            Console.WriteLine($"Success! {_Name}, you have {this._Balance}deneg on account.");
        }
        else { Console.WriteLine($"Wrong password! Are you {_Name}?!"); }
    }
    public void withdraw(int pass, int sum)
    {
        if (pass == this._Password && sum <= this._Balance)
        {
            this._Balance -= sum;
            Console.WriteLine($"{_Name}, take your cash! You have {this._Balance}deneg on account.");
        }
        else if (pass != this._Password) { Console.WriteLine($"Wrong password! Are you {_Name}?!"); }
        else { Console.WriteLine($"Not enough money on account. {_Name}, you have only {this._Balance}deneg on account."); }
    }
    public BankAccount(string name, int pass) { 
        this._Name = name;
        this._Password = pass;
        Console.WriteLine($"Creating new account!\nName: {_Name}\nPassword: {_Password}");
    }
}