{
    Pair<string, int> pair = new Pair<string, int>("abc", 123);
    pair.SetValueT("qwe");
    Console.WriteLine($"{pair.GetValueT()} ,  {pair.GetValueU()}");
}
class Pair<T, U>
{
    private T _ValueT;
    private U _ValueU;
    public Pair(T ValueT, U ValueU) {  _ValueT = ValueT; _ValueU = ValueU; }
    public void SetValueT(T ValueT) { _ValueT= ValueT; }
    public void SetValueU(U ValueU) { _ValueU = ValueU; }
    public T GetValueT() { return _ValueT; }
    public U GetValueU() { return _ValueU; }
}