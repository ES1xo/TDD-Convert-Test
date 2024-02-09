using System;

public class Program
{
    public static double ConvertUnits(double value, string unit)
    {
        switch (unit)
        {
            
            case "cm":
                return value * 2.54;
            case "mm":
                return ConvertInchesToMilimeters(value);
            default:
                throw new ArgumentException("Invalid unit");
        }
        
    }

    public static double ConvertInchesToMilimeters(double inches)
    {
        throw new NotImplementedException("Function not implemented)");
    }

    public static void Main(string[] args)
    {
        if (args.Length > 0 && args[0] == "-t")

        {
            runTests(args);
        }
        else
        {
            ConvertUnits(10, "cm");
        }
    }
    

    public static void runTests(string[] args)
    {
        TestFunction(() => (10) == 25.4, "Convert 10 inches to milimeters");
        TestFunction(() => (0) == 0, "Convert 0 inches to centimeters");
        TestFunction(() => (-1) == -2.54, "Convert -1 inches to centimeters");
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

