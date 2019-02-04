using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class BuilderDemo : IExecutable
    {
        public void Run()
        {
            Console.WriteLine("Creating sandwich builder...");
            var builder = new SandwichBuilder();
            Console.WriteLine("Done.");

            Console.WriteLine();

            Console.WriteLine("Creating sandwich 1...");
            var sandwich1 =
                builder
                    .AddBread("Rye")
                    .AddMeat("Chicken")
                    .AddMeat("Turkey")
                    .AddSauce("Mayo")
                    .GetSandwich();
            Console.WriteLine("Done.");

            DisplaySandwich(sandwich1);

            Console.WriteLine();

            Console.WriteLine("Creating sandwich 2...");
            var sandwich2 =
                builder
                    .Reset()
                    .AddCondiment("Tomato")
                    .AddMeat("Salami")
                    .AddCondiment("Lettuce")
                    .AddBread("Sourdough")
                    .AddCondiment("Onion")
                    .GetSandwich();
            Console.WriteLine("Done.");

            DisplaySandwich(sandwich2);
        }

        private void DisplaySandwich(Sandwich sandwich)
        {
            Console.WriteLine("Bread:".PadRight(15, ' ') + $"{sandwich.Bread}");
            Console.WriteLine("Meats:".PadRight(15, ' ') + $"{sandwich.Meats}");
            Console.WriteLine("Condiments:".PadRight(15, ' ') + $"{sandwich.Condiments}");
            Console.WriteLine("Sauce:".PadRight(15, ' ') + $"{sandwich.Sauce}");
        }
    }
}
