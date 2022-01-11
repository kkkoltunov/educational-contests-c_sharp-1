using System;

public class Rational
{
    int numerator;
    int denomenator;
    
    public Rational(int numerator, int denomenator)
    {
        this.numerator = numerator;
        this.denomenator = denomenator;
    }

    public static Rational Parse(string input)
    {
        if (input.Contains('/'))
        {
            string[] data = input.Split('/');
            return new Rational(int.Parse(data[0]), int.Parse(data[1]));
        }
        else
        {
            return new Rational(int.Parse(input), 1);
        }
    }

    public override string ToString()
    {
        if (denomenator == 1)
            return numerator.ToString();
        return numerator + "/" + denomenator;
    }

    private void Reduction()
    {
        if (numerator == denomenator)
        {
            numerator = 1;
            denomenator = 1;
            return;
        }

        if (Math.Abs(numerator) == denomenator)
        {
            numerator = -1;
            denomenator = 1;
            return;
        }

        if (numerator == Math.Abs(denomenator))
        {
            numerator = -1;
            denomenator = 1;
            return;
        }

        if (denomenator < 0)
        {
            denomenator *= -1;
            numerator *= -1;
        }

        int maxMod = 1;

        if (numerator > denomenator)
            maxMod = numerator;
        else
            maxMod = denomenator;

        for (int i = maxMod; i >= 2; maxMod--)
        {
            if (numerator % maxMod == 0 && denomenator % maxMod == 0)
            {
                numerator /= maxMod;
                denomenator /= maxMod;
                break;
            }
        }
    }


    public static Rational operator +(Rational rational1, Rational rational2)
    {
        if (rational1.denomenator == rational2.denomenator)
        {
            Rational rational = new Rational(rational1.numerator + rational2.numerator, rational2.denomenator);
            rational.Reduction();
            return rational;
        }
        else
        {
            Rational rational = new Rational((rational1.numerator * rational2.denomenator) + (rational2.numerator * rational1.denomenator), rational1.denomenator * rational2.denomenator);
            rational.Reduction();
            return rational;
        }
    }

    public static Rational operator -(Rational rational1, Rational rational2)
    {
        if (rational1.denomenator == rational2.denomenator)
        {
            Rational rational = new Rational(rational1.numerator - rational2.numerator, rational2.denomenator);
            rational.Reduction();
            return rational;
        }
        else
        {
            Rational rational = new Rational((rational1.numerator * rational2.denomenator) - (rational2.numerator * rational1.denomenator), rational1.denomenator * rational2.denomenator);
            rational.Reduction();
            return rational;
        }
    }

    public static Rational operator *(Rational rational1, Rational rational2)
    {
        Rational rational = new Rational(rational1.numerator * rational2.numerator, rational1.denomenator * rational2.denomenator);
        rational.Reduction();
        return rational;
    }

    public static Rational operator /(Rational rational1, Rational rational2)
    {
        Rational rational = new Rational(rational1.numerator * rational2.denomenator, rational1.denomenator * rational2.numerator);
        rational.Reduction();
        return rational;
    }
}