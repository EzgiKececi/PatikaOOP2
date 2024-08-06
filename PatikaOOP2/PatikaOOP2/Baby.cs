public class Baby
{
    private string _name;
    private string _surname;
    private DateTime _birthDate;

    
    public string Name { get { return _name; } set { _name = value; } } 
    public string Surname { get { return _surname; } set { _surname = value; } }
    public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; } }

    public Baby()  // Default constructor

    {
        Console.WriteLine("INGAAAA!");
        _birthDate = DateTime.Now;
    } 
    public Baby(string name, string surname) // Parametre ile çalışacak constructor
    {
        _name = name;
        _surname = surname;
        Console.WriteLine("INGAAAA!");
        _birthDate = DateTime.Now;
    }


    public void NewBornBaby() 
    {
        
        Console.WriteLine($"{_name} {_surname} adlı bebek {_birthDate} tarihinde ve saatinde doğdu.");

    }



}

 

    