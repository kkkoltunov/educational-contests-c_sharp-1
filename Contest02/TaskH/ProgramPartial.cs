using System;

partial class Program
{
    static int MorningWorkout(string dayOfWeek, int firstNumber, int secondNumber)
    {
        int res = -101010;
        int remainder1 = 1;
        int remainder2 = 2;

        firstNumber = Math.Abs(firstNumber);
        secondNumber = Math.Abs(secondNumber);

        switch (dayOfWeek)
        {
            case "Monday":
            case "Wednesday":
            case "Friday": res = GetSumOfOddOrEvenDigits(firstNumber, remainder1);
                break;
            case "Tuesday": 
            case "Thursday": res = GetSumOfOddOrEvenDigits(secondNumber, remainder2);
                break;
            case "Saturday": res = Maximum(firstNumber, secondNumber);
                break;
            case "Sunday": res = Multiply(firstNumber, secondNumber);
                break;
        }  

        if (res == -101010)
        {
            res = int.MinValue;
        }

        return res;
    }

    static int GetSumOfOddOrEvenDigits(int value, int remainder)
    {
        int sum = 0;

        if (remainder == 1)
        {
            while (value != 0)
            {
                if (value % 2 == 1)
                {
                    sum += (value % 10);
                }
                value /= 10;
            }
        }

        if (remainder == 2)
        {
            while (value != 0)
            {
                if (value % 2 == 0)
                {
                    sum += (value % 10);
                }
                value /= 10;
            }
        }

        return sum;
    }

    static int Multiply(int firstValue, int secondValue)
    {
        return firstValue * secondValue;
    }

    static int Maximum(int firstValue, int secondValue)
    {
        return Math.Max(firstValue, secondValue);
    }
}