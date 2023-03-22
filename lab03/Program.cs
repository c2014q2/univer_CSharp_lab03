// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Specialized;
using System.Reflection.Metadata;
using lab03;


public class Program
{
    public static void Main(string[] args)
    {
         const string Ttt = "-------------------------------";
        Automobil car = new Automobil("Toyota Sprinter Trueno",4,7,4);
        
        car.Print();
        Console.WriteLine(Ttt);
        
        Bicicleta bike = new Bicicleta("BMX",2,"Black",2006);
        bike.Print();
        Console.WriteLine(Ttt);
        
        
        Camion camion = new Camion(6, "Truck",7,3,2170);
        camion.Print();
        Console.WriteLine(Ttt);

        // Shape triunghi = new Shape(); //nu merge :(


        Square patrat = new Square(3);
        Circle cerc = new Circle(3);
        Triangle tri = new Triangle(8, 3);

        Shape[] lista = new Shape[] { patrat, cerc, tri };
        foreach (var pShape in lista)
        {
            pShape.GetArea();
        }




       
       
        

        Console.ReadLine();
    }



}