partial class Program
{
    private static string Encrypt(string input)
    {
        char max;
        char min;

        int countMax = 0;
        int countMin = 0;

        char[] inputChar = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            inputChar[i] = input[i];
        }

        for (int i = 0; i < input.Length; i++)
        {
            char tempMax = input[i];

            for (int j = 0; j < input.Length; j++)
            {
                if (tempMax == inputChar[i])
                {
                    countMax = 
                }
            }
        }
    }
}
