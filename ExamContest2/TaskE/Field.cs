using System;

public class Field
{
    private int[][] matrix;

    public Field(int[][] matrix)
    {
        this.matrix = matrix;
        
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new int[matrix.Length];
        }
    }

    public void FillIn(string fillType)
    {
        int start = 1;

        switch (fillType)
        {
            case "right to left":
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] = matrix[i].Length - j + i;
                    }
                    start++;
                }
                break;

            case "left to right":
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] = start + j;
                    }
                    start++;
                }
                break;

            default:
                throw new ArgumentException("Incorrect input");
        }
    }

    public override string ToString()
    {
        string answer = "";

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                answer += matrix[i][j].ToString();

                if (j + 1 != j)
                {
                    answer += " ";
                }
            }

            if (i + 1 != i)
            {
                answer += "\n";
            }
        }

        return answer;
    }
}