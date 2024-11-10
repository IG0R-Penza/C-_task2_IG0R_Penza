{
    ListStorage<string> students_names = new ListStorage<string>();
    students_names.Add("alice");
    students_names.Add("bob");
    students_names.Add("charlie");
    Console.WriteLine(students_names.Get(0));
    Console.WriteLine(students_names.Get(1));
    Console.WriteLine(students_names.Get(2));
}
interface IStorage<T>
{
    public void Add(T element);
    public T Get(int index);
}
class ListStorage<T> : IStorage<T>
{
    List<T> _list=new List<T>();
    public void Add(T element){_list.Add(element);}
    public T Get(int index) { return _list[index]; }
}