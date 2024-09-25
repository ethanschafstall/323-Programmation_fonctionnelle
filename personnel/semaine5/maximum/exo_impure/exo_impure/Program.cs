using System;
using System.Threading;

class Program
{
    static int linesOfCode = 9210;
    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine($"Opening shop with {linesOfCode} lines in our program");
        int value = linesOfCode;

        Thread thread1 = new Thread(await => Bob(value) );
        Thread thread2 = new Thread((await => Alice(value)));

        // Start both threads
        thread1.Start();
        Thread.Sleep(300); // Alice starts her day a bit later
        thread2.Start();

        // Wait until both threads terminate
        thread1.Join();
        thread2.Join();

        Console.WriteLine($"Closing shop with {linesOfCode} lines in our program");
        Console.ReadLine();
    }

    static async Task<int> Bob(int oldCodeLines)
    {
        int newLines = 0;
        int myLineCounter = oldCodeLines; // Bob starts working
        int workingHours = 0;

        while (workingHours < 9) // He has a 9-hours day ahead of him
        {
            Thread.Sleep(1000); // Bob works for "1 hour"
            workingHours++;
            int BobProduction = random.Next(10, 50);
            Console.WriteLine($"Bob commits {BobProduction} lines of code.");
            newLines += BobProduction;
        }
        Console.WriteLine($"Bob checks out, he claims the program has now {myLineCounter + newLines} lines");
        return newLines; // he turns his work in
    }

    // Method to be executed by thread2 - increments by 2 every 3 seconds
    static async Task<int> Alice(int oldCodeLines)
    {
        int newLines = 0;
        int myLineCounter = oldCodeLines; // Alice starts working
        int workingHours = 0;
        while (workingHours < 7) // She has a 7-hours day ahead of her
        {
            Thread.Sleep(1000); // Alice works for "1 hour"
            workingHours++;
            int AliceProduction = random.Next(20, 80);
            Console.WriteLine($"Alice commits {AliceProduction} lines of code.");
            myLineCounter += AliceProduction;
        }
        Console.WriteLine($"Alice checks out, she claims the program has now {myLineCounter + newLines} lines");
        return newLines; // she turns her work in
    }
}
