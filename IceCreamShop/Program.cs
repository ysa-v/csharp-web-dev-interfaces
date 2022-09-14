using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;


            Console.WriteLine("Flavors Before Sort:\n");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }

            availableFlavors.Sort(new FlavorComparer());

            Console.WriteLine("\nFlavors After Sort:\n");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }

            Console.WriteLine("\nCones Before Sort:\n");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name}: ${cone.Cost}");
            }

            availableCones.Sort(new ConeComparer());

            Console.WriteLine("\nCones After Sort:\n");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name}: ${cone.Cost}");
            }
        }
    }
}
