using System;

public class Program
{
    public static double ConvertUnits(double value, string unit)
    {
        switch (unit)
        {
            
            case "-cm":
                return value * 2.54;
            case "-mm":
                return value * 25.4;
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
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double inches = 0;

        if (args.Length > 0 && args[0] == "-t")

        {
            runTests(args);
            return;
        }
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: dotnet run <inches> <-unit>");
            return;
        }
        if (!double.TryParse(args[0], out inches))
        {
            Console.WriteLine("Invalid number");
            return;
        }   
        
        string unit = args[1].ToLower();

        double result = ConvertUnits(inches, unit);
        Console.WriteLine($"Result: {result} {unit}");
    }
    

    public static void runTests(string[] args)
    {
        TestFunction(() => ConvertUnits(10, "-mm") == 254, "Convert 10 inches to milimeters");
        TestFunction(() => ConvertUnits(0, "-cm") == 0, "Convert 0 inches to centimeters");
        TestFunction(() => ConvertUnits(-1, "-m") == -2.54, "Convert -1 inches to centimeters");
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

