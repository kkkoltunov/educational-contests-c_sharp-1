using System;

class Program
{
    public static void Main(string[] args)
    {
        int maxFirst = int.MinValue;
        int maxSecond = int.MinValue;

        int input;

        while (true)    
        {
            bool flag = int.TryParse(Console.ReadLine(), out input);

            if (input == 0)
            {
                break;
            }
            else if (!flag || input < 100 || input > 150)
            {
                Console.WriteLine("Incorrect number");
            }
            else
            {
                if (input > maxSecond)
                {
                    if (input > maxFirst)
                    {
                        maxSecond = maxFirst;
                        maxFirst = input;
                    }
                    else
                    {
                        maxSecond = input;
                    }
                }
            }
        }

        Console.WriteLine(maxFirst);
        Console.WriteLine(maxSecond);
    }
}