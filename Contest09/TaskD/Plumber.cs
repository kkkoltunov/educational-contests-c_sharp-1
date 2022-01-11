public class Plumber : IPlumber
{
    public void FixPipe(ref int numberOfCrashes)
    {
        if (numberOfCrashes > 0)
            numberOfCrashes -= 1;
    }
}