using System.Globalization;

namespace PP_Uke4;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Gi din Pet et navn");
        Pet myPet = new Pet(Console.ReadLine());
        Console.WriteLine("Si hei til {0}", myPet.Name);
        myPet.ShowOptions();
        
        Console.Read();
    }

    public class Pet
    {
       public string Name { get; set; }
       public int hunger = 0;
       public int mood = 100;
       public bool needsBathroom  = false;

       public Pet(string name)
       {
          Name = name; 
       }

       public void ShowOptions()
       {
           
           Console.WriteLine("1. Gi {0} mat\n2. Kos med {0}\n3. Sjekk om {0} må på do", Name );
           Console.WriteLine();
       }
    }
    
    
}