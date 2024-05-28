using System.Runtime.Intrinsics.X86;

namespace ConsoleApp12;

class Program
{
    static void Main(string[] args)
    {
        Krokodillespillet();
    }

    public static void Krokodillespillet()
    {
        Random random = new Random();
        int num1 = 0;
        int num2 = 0;
        int points = 0;
        bool isActive = true;

        while (isActive)
        {
             num1 = random.Next(1, 11);
             num2 = random.Next(1, 11);
            Console.WriteLine("*** Krokodillespillet ***");
            Console.WriteLine(
                $"answer with <, >, = or press any other key to exit.");
            Console.Write($"{num1} _ {num2} ? \t\tpoints: {points}\n");
            var input = Console.ReadLine();
            switch (input)
            {
                case "<":
                    if ("<" == CheckAnswer(num1, num2))
                    {
                        points++;
                    }
                    else
                    {
                        points--;
                    }

                    Console.Clear();
                    break;
                case ">":

                    if (">" == CheckAnswer(num1, num2))
                    {
                        points++;
                    }
                    else
                    {
                        points--;
                    }
                    Console.Clear();
                    break;
                case "=":

                    if ("=" == CheckAnswer(num1, num2))
                    {
                        points++;
                    }
                    else
                    {
                        points--;
                    }
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Exit from game!");
                    points--;
                    isActive = false;
                    //Console.Clear();
                    break;
            }
        }
    }

    public static string CheckAnswer(int a, int b)
    {
        if (a < b)
        {
            return "<";
        }
        else if (a > b)
        {
            return ">";
        }
        else if (a == b)
        {
            return "=";
        }
        else
        {
            return "X";
        }
    }
}