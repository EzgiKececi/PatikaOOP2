using System.Reflection.Metadata;

public class Program
{
    static void Main(string[] args)
    {
        Baby baby1 = new Baby("Minik", "Bebek"); //Baby sınıfından parametre alan constructor ile yeni nesne
        baby1.NewBornBaby();
        Console.WriteLine("----------------------");

        Baby baby2 = new Baby(); //Baby sınıfından default constructor ile yeni nesne
        baby2.Name = "Küçük";
        baby2.Surname = "Bebek";
        baby2.NewBornBaby();
    }
    
}