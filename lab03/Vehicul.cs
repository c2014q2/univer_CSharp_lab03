using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

namespace lab03;

public abstract class Vehicul
{
    protected string nume ;
    protected int starea;

    protected int roti; 
    protected bool AreRoti = false;
    protected int NrLocuri;
    public abstract void Print();



}

public class Pamant : Vehicul
{
    
    public override void Print()
    {
        Console.WriteLine("Nume:{0}\nStarea (1-10):{4}\nAreRoti:{1}\nRoti:{2}\nNrLocuri:{3}",nume,AreRoti,roti,NrLocuri,starea);
    }
}

public class Bicicleta : Pamant
{
    private string culoare;
    private int PurchasedDate;
    public Bicicleta(string nume , int roti,string culoare, int date)
    {
        NrLocuri = 1; 
        this.nume = nume;
        this.roti = roti;
        if (roti > 0) AreRoti = true;
        this.culoare = culoare;
        PurchasedDate = date;
    }

    public new void Print()
    {
        Console.WriteLine("Nume:{0}\nAreRoti:{1}\nRoti:{2}\nNrLocuri:{3}\nCuloare:{5}\nPurchasedYear:{6}"
            ,nume,AreRoti,roti,NrLocuri,starea,culoare,PurchasedDate);
    }

}

public class Automobil : Pamant
{ 
    public Automobil(string nume,int roti, int starea, int loc)
    {
        this.NrLocuri = loc;
        this.nume = nume;
        this.roti = roti;
        this.starea = starea;
        if (roti > 0) AreRoti = true;
    }
}

public class Camion : Pamant
{
    private int greutatea;
    public Camion(int roti, string nume, int starea, int loc, int greutatea) 
    {
        this.starea = starea;
        this.roti = roti;
        if (roti > 0) AreRoti = true;
        this.greutatea = greutatea;
        this.NrLocuri = loc;

        this.nume = nume;
    }

    public new void Print()
    {
        Console.WriteLine("Nume:{0}\nStarea (1-10):{4}\nAreRoti:{1}\nRoti:{2}\nNrLocuri:{3}\nGreutatea:{5}",
            nume,AreRoti,roti,NrLocuri,starea,greutatea);
    }
}