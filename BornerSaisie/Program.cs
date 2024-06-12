using System;

class Program
{
    public static void Main()
    {
        Console.Write("saisir un minimum: ");
        string input = Console.ReadLine();
        int min = Convert.ToInt32(input);
        Console.Write("saisir un maximum: ");
        string input2 = Console.ReadLine();
        int max = Convert.ToInt32(input2);

        Console.Write("entier à placer: ");
        string input3 = Console.ReadLine();
        int x = Convert.ToInt32(input3);

        if (x < min)
        {
            Console.Write("You have entered " + x);
            Console.Write(" which is lower than " + min);
            Console.WriteLine(" which is the minimum");
            Console.WriteLine("resulting integer " + min);
        }
        else if (x > max)
        {
            Console.Write("You have entered " + x);
            Console.Write(" which is higher than " + max);
            Console.WriteLine(" which is the maximum");
            Console.WriteLine("resulting integer " + max);
        }
        else
        {
            Console.Write("you are inbetween the limits");
            Console.WriteLine(" resulting integer: " + x);
        }


    }
}
