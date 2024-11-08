{
    Rectangle pryamoug = new Rectangle();
    pryamoug.Width = 3;
    pryamoug.Height = 4;
    Circle krug = new Circle();
    krug.Radius = 3;
    Console.WriteLine($"Площадь прямоугольника: {pryamoug.GetArea()}\nПлощадь круга: {krug.GetArea()}");
}
abstract class Shape
{
    public abstract double GetArea();
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double GetArea()
    {
        return (Width * Height);
    }
}
class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea()
    {
        return Radius*Radius*3.14;
    }
}