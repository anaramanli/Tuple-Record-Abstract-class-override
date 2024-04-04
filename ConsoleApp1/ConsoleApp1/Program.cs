namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Tuple
            /*(int, string) result = A();

            static (int, string) A()
            {
                return (1, "salam");
            }*/


            /* Record
            VintageCarrecord car1 = new VintageCarrecord("Mustang", "Ford" , 1969, "4.7","Benzin-95");
            VintageCarrecord car2 = new VintageCarrecord("F40", "Ferrari" );

            VintageCarrecord car2 = car1 with { ModelName = "Taycan", CarName = "Porsche" ,FuelType = "Electric"};

            Console.WriteLine(car1);
            Console.WriteLine(car2);

            VintageCarrecord car2 = car1 with { };
                        Console.WriteLine(car2);

            car1.Deconstruct(out string CarName, out string ModelName);
            Console.WriteLine(ModelName + " " + CarName);

            {
                ModelName = "Mustang",
                CarName = "Ford"
            };
            Console.WriteLine(car1 == car2);
            Console.WriteLine(Object.ReferenceEquals(car1, car2));*/

            // Abstract class, override

            Fox myFox = new Fox();
            myFox.animalSound();
            myFox.sleep();

        }
    }

    abstract class Animal //ABSTRACT CLASS
    {
        public abstract void animalSound(); // ABSTRACT METHODU

        public void sleep()
        {
            Console.WriteLine("Zzz");
        }   
    }

    class Fox :Animal
    {
        //OVERRIDE 
        public override void animalSound()
        {
            Console.WriteLine("The fox says: Ding ding ");  //BODY OF ANIMAL SOUND 
        }
    }
    /*internal record VintageCarrecord(string ModelName = "Model", string CarName = "name", int Year = 0, string Engine = " ", string FuelType = "")
    {
        /*public string ModelName { get; init; }
        public string CarName { get; init; } = "XXX";#1#

    }

    internal class SuperCarclass
    {
        public string ModelName { get; set; }
        public string CarName { get; set; } = "XXX";

    }*/

}
