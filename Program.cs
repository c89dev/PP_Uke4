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
    }

    public class Pet
    {
        public string Name { get; set; }
        public bool hungry = false;
        public bool happy = false;
        public bool needsBathroom = false;
        public int days = 1;

        public Pet(string name)
        {
            Name = name;
        }

        public void ShowOptions()
        {
            Console.Clear();
            Console.WriteLine($"day: {days}");
            Console.WriteLine("1. Gi {0} mat\n2. Kos med {0}\n3. Sjekk om {0} må på do", Name);


            feilsvar:
            switch (Console.ReadLine())
            {
                case "1":
                    if (hungry)
                    {
                        hungry = false;
                        Console.WriteLine($"{Name} er mett og fornøyd");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} er ikke sulten");
                        goto feilsvar;
                    }
                    break;


                case "2":
                    if (happy)
                    {
                        Console.WriteLine($"{Name} er fortsatt glad");
                        goto feilsvar;
                    }
                    else
                    {
                        happy = true;
                        Console.WriteLine("{0} smiler", Name);
                    }
                    
                    break;

                case "3":
                    if (needsBathroom)
                    {
                        needsBathroom = false;
                        Console.WriteLine($"{Name} er færdig med sitt");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} må ikke på do");
                        goto feilsvar;
                    }
                    break;

                default:
                    Console.WriteLine($"{Name} forsto ikke den komandoen");
                    goto feilsvar;
            }
            days++;



            Random rand = new Random();
            switch (rand.Next(1, 4))
            {
                case 1:
                    hungry = true;
                    break;

                case 2:
                    happy = false;
                    break;

                case 3:
                    needsBathroom = true;
                    break;
            }



            Console.ReadLine();
            this.ShowOptions();
        }
    }


}