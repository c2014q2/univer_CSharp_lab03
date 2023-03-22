namespace lab03;

public abstract class Shape
{
    public abstract void GetArea();

}

public class Square : Shape
{
    private int Lenght;
    public Square(int SideLeght)
    {
        Lenght = SideLeght;
    }
    
    public override void GetArea()
    {
        Console.WriteLine("Aria Patratului = "+Lenght*Lenght);
    }
}


public class Circle : Shape
{
    private int radius;
    private static double pi = 3.14;
    public Circle(int radius)
    {
        this.radius = radius;
    }

    public override void GetArea()
    {
        Console.WriteLine("Aria cercului = "+pi*(radius*radius));
    }
}

public class Triangle : Shape
{
    private int baza;
    private int height;

    public Triangle(int baza , int height)
    {
        this.baza = baza;
        this.height = height;
        
    }

    public override void GetArea()
    {
        Console.WriteLine("Aria triunghiului = "+(baza*height)/2);
    }
}