myClass my1=new myClass(1);
myClass my2=new myClass(2);
myClass my3=new myClass(3);
myClass[] mys = {my1,my2,my3};
Repository<myClass> rep = new Repository<myClass>(mys, 3);
rep.setObject(my3, 0);
myClass newmy = rep.getObject(0);
Console.WriteLine(newmy.getValue());

class Repository<T> where T : class
{
    private T[] _objects;
    private int _lenght;
    public Repository(T[] objects, int lenght) { _objects = objects; _lenght = lenght; }
    public void setObject(T obj, int index) { if (index < _lenght) { _objects[index] = obj; }}
    public T getObject(int index) { if (index < _lenght) { return _objects[index]; }
        else { return _objects[_lenght - 1]; }
    }
}
class myClass
{
    private int _Value;
    public myClass(int value) { _Value = value; }
    public int getValue() { return _Value; }
}