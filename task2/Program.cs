int[] NumArray = { 3, 4, 1 };
FindMin<int> nums = new FindMin<int>(NumArray);
int min = nums.Find();
Console.WriteLine(min);
class FindMin<T> where T : IComparable
{
    private T[] _values;
    public FindMin(T[] values){_values=values; }
    public T Find() { Array.Sort(_values);
        return _values[0];
    }
}