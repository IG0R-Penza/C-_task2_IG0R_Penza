{
    double price = 1000.0;
    Discount AmountSkidka = new FixedAmountDiscount(50.96);
    Discount PercentSkidka = new PercentageDiscount(15);
    Console.WriteLine(AmountSkidka.Calculate(price));
    Console.WriteLine(PercentSkidka.Calculate(price));
}

class Discount
{
    public virtual double Calculate(double price) { return price; }
}
class FixedAmountDiscount : Discount
{
    private double _amount;
    public FixedAmountDiscount(double amount) { _amount = amount; }
    public override double Calculate(double price)
    {
        return price - _amount;
    }
}
class PercentageDiscount : Discount
{
    private int _percentage;
    public PercentageDiscount(int percentage) { _percentage = percentage; }
    public override double Calculate(double price) { return price - price * (_percentage * 0.01); }
}