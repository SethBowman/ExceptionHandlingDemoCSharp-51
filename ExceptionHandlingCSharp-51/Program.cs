namespace ExceptionHandlingCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new int[] { 1, 2, 3, 4, 5 };

        //try-catch block

        try
        {
            Console.WriteLine(numbers[10]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"That was not an index that exists. {ex.Message}");
        }
        catch (Exception ex)
        {
            //umbrella catch, catches all exceptions we may have missed
            Console.WriteLine(ex.Message);
        }
        finally
        {
            //optional
            //happens no matter
            Console.WriteLine("Finally block");
        }

        Console.WriteLine("Continue on..");

        try
        {
            Console.WriteLine("Give me a number:");
            var userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(userInput);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Continue on..");

        var strNumbers = new string[] { "23", "two", "405", "ten", "65", "four", "10" };
        var realNumbers = new List<int>();

        foreach (var strNumber in strNumbers)
        {
            try
            {
                var parsedNumber = int.Parse(strNumber);
                realNumbers.Add(parsedNumber);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Could not parse {strNumber} to an integer. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine("Parsed numbers:");

        foreach (var number in realNumbers)
        {
            Console.WriteLine(number);
        }
    }
}