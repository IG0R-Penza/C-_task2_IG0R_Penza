int num1 = 1;
int num2 = 2;
Console.WriteLine($"before swap: {num1}, {num2}");
Swapper<int>.Swap(ref num1,ref num2);
Console.WriteLine($"after swap: {num1}, {num2}");

static class Swapper<T>
{
    static public void Swap(ref T value1, ref T value2)
    {
        T temp = value1;
        value1=value2;
        value2=temp;
    }
}