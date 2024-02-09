using System;

public class Program
{
    public static double ConvertInchesToCentimeters(double inches)
    {
        return inches * 2.54;
    }

    public static void Main(string[] args)
    {
        TestFunction(() => ConvertInchesToCentimeters(10) == 25.4, "Convert 10 inches to centimeters");
        TestFunction(() => ConvertInchesToCentimeters(0) == 0, "Convert 0 inches to centimeters");
        TestFunction(() => ConvertInchesToCentimeters(-1) == -2.54, "Convert -1 inches to centimeters");
    }

    public static void TestFunction(Func<bool> evaluation, string description)
    {
        try
        {
            if (evaluation())
            {
                // Must be true
                Console.WriteLine($"🟢 Test:  {description}");
            }
            else
            {
                Console.WriteLine($"🔴 Test: {description}");
            }
        }
        catch (Exception)
        {
            Console.WriteLine($"🔴 Test: {description}");
        }
    }
}

