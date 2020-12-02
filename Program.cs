using System;
using PatternDuck.Ducks;
namespace PatternDuck
{

    class Program
    {
        static void Main()
        {
            MallardDuck mallardDuck = new MallardDuck();
            ModelDuck modelDuck = new ModelDuck();
            RubberDuck rubberDuck = new RubberDuck();
            IronDuck ironDuck = new IronDuck();

            Duck[] duck = { mallardDuck, modelDuck, rubberDuck, ironDuck };
            foreach (Duck x in duck)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("0: " + x.Display);
                Console.WriteLine("1: " + x.PerformSwim);
                Console.WriteLine("2: " + x.PerformQuack);
                Console.WriteLine("3: " + x.PerformFly);
            }
            Console.WriteLine("----------------------------------");
            Console.ReadKey();
        }
    }
}
