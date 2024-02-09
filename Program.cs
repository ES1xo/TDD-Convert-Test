using System;

public class Program
{
    public static double ConvertInchesToCentimeters(double inches)
    {
        return inches * 2.54;
    }

    public static void Main(string[] args)
    {
        if (args.Length > 0 && args[0] == "-t")

        {
            runTests(args);
        }
        else
        {
            Console.WriteLine(ConvertInchesToCentimeters(10));
        }
    }

    public static void runTests(string[] args)
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
                
                Console.WriteLine($"🟢 Test Succesful:  {description}");
            }
            else
            {
                Console.WriteLine($"🔴 Test Failed: {description}");
            }
        }
        catch (Exception)
        {
            Console.WriteLine($"🔴 Test Failed: {description}");
        }
    }
}

