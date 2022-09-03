using System;

class RebuildDeliverable1
{
    public static void Main (string[] args)
    {

        /*Feed the Neighborhood Project Conversions
        1 sandwich = 1 person
        1 Sandwich = 2 slices of bread, 2 tbsp of pb, and 4 tsp of jelly
        1 loaf of bread = 28 slices
        1 jar of pb = 32 tbsp
        1 jar of jelly = 48 tsp*/

        /*Declare variables to be used*/
        /*This defines units per jar/loaf*/
        int slicesperloaf = 28;
        int tbspperjarofPB = 32;
        int tspperjarofJelly = 48;
        string answer;

        /*Loop starts here*/
        do
        {
            /*Ask for input of how many people there are*/
            Console.WriteLine("How many people are you feeding?");
            int people = int.Parse(Console.ReadLine());

            /*This calculates units needed*/
            double totalSlicesNeeded = people * 2;
            double totalTbspofPbNeeded = people * 2;
            double totaltspofJellyNeeded = people * 4;

            /*This converts units needed to loaves/jars needed
            These need to be whole numbers*/
            /*I may be able to use "Math.Ceiling" here*/
            double totalloavesNeeded = totalSlicesNeeded / slicesperloaf;
            double totaljarsofpbNeeded = totalTbspofPbNeeded / tbspperjarofPB;
            double totaljarsofjellyNeeded = totaltspofJellyNeeded / tspperjarofJelly;

            double l = Math.Ceiling(totalloavesNeeded);
            double p = Math.Ceiling(totaljarsofpbNeeded);
            double j = Math.Ceiling(totaljarsofjellyNeeded);

            /*This outputs the unit calculations*/
            Console.WriteLine(@"
    If eveyone eats one sandwich, you will need:
    ");
            Console.WriteLine("     " + totalSlicesNeeded + " slices of bread");
            Console.WriteLine("     " + totalTbspofPbNeeded + " tablespoons of peanut butter");
            Console.WriteLine("     " + totaltspofJellyNeeded + " teaspoons of jelly");

            Console.WriteLine(@"

    which is...

    ");

            /*This outputs the loaf/jar calculations*/
            Console.WriteLine("     " + l + " loaves of bread");
            Console.WriteLine("     " + p + " jars of peanut butter");
            Console.WriteLine("     " + j + " jars of jelly");

            Console.WriteLine(@"
    Would you like to restart? 
    Enter yes or y to continue, 
    or enter any other key to exit.");

            answer = Console.ReadLine();

        } while (answer == "yes" || answer == "y");

        Console.WriteLine("Goodbye!");
    }
}