using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = new string[3];

            text[0] = " ";
            text[1] = "";
            text[2] = "1234";

            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
