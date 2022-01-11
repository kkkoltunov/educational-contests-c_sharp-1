using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegralCalculator
{
    public static void InsertParameter(int param)
    {
        switch (param)
        {
            case 0:
                Program.func = Sinus;
                break;
            case 1:
                Program.func = Cosinus;
                break;
            case 2:
                Program.func = Tangent;
                break;
        }
    }

    public static double Tangent(double left, double right)
    {
        double square = 0;
        double y0 = 0;
        double y1 = 0;

        while (left < right)
        {
            y0 = Math.Tan(left);
            y1 = Math.Tan(left + Program.EPSYLON);

            square += ((y0 + y1) / 2.0) * Program.EPSYLON;

            left += Program.EPSYLON;
        }

        //y0 = Math.Tan(left);
        //y1 = Math.Tan(left + Program.EPSYLON);

        //square += ((y0 + y1) / 2) * Program.EPSYLON;

        return square;
    }

    public static double Sinus(double left, double right)
    {
        double square = 0;
        double y0 = 0;
        double y1 = 0;

        while (left < right)
        {
            y0 = Math.Sin(left);
            y1 = Math.Sin(left + Program.EPSYLON);

            square += ((y0 + y1) / 2.0) * Program.EPSYLON;

            left += Program.EPSYLON;
        }

        //y0 = Math.Sin(left);
        //y1 = Math.Sin(left + Program.EPSYLON);

        //square += ((y0 + y1) / 2) * (Program.EPSYLON);

        return square;
    }

    public static double Cosinus(double left, double right)
    {
        double square = 0;
        double y0 = 0;
        double y1 = 0;

        while (left < right)
        {
            y0 = Math.Cos(left);
            y1 = Math.Cos(left + Program.EPSYLON);

            square += ((y0 + y1) / 2.0) * Program.EPSYLON;

            left += Program.EPSYLON;
        }

        //y0 = Math.Cos(left);
        //y1 = Math.Cos(left + Program.EPSYLON);

        //square += ((y0 + y1) / 2) * Program.EPSYLON;

        return square;
    }

}

