// See https://aka.ms/new-console-template for more information

Console.WriteLine("Area of the rectangle ..");

Rectangle rec = new(2, 3);
Console.WriteLine($"Area of the rectangle : {Area(rec)}");

Rectangle sq = new Square();
sq.Width = 4;

Console.WriteLine($"Area of the Square : {Area(sq)}");


Console.ReadLine();


int Area(Rectangle r)=> r.Width * r.Height;

public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public Rectangle()
    {
        
    }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

public class Square : Rectangle
{
    public override int Width
    {
        set => base.Width = base.Height = value;
    }

    public override int Height
    {
        set => base.Width = base.Height = value;
    }
}