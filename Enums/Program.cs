// See https://aka.ms/new-console-template for more information
using Enums;

class Program
{
    public static void Main(string[] args)
    {
        StartRoutine();
    }

    private static void StartRoutine()
    {
        Console.WriteLine("Введите порядковый номер дня недели (Monday = 1 ... Saturday = 7 :");
        string userInput = Console.ReadLine();

        byte numberOfDay = CheckUserInput(userInput);
        if (numberOfDay != 0) WriteToConsole(numberOfDay);
    }

    private static byte CheckUserInput(string valueToCheck)
    {
        byte userInput = 0;
        bool inputIsValid = true;
        try
        {
            // use TryParse instead
            userInput = checked (byte.Parse(valueToCheck));
        }
        catch
        {
        }
        finally
        {
            if (userInput < 1 || userInput > Enum.GetNames(typeof(DaysOfWeek)).Length + 1)
            {
                Console.WriteLine("Введите целочисленное значение от 1 до 7");
                userInput = 0;
            }
        }
        return userInput;
    }
    private static void WriteToConsole(byte numberOfDay)
    {
        DaysOfWeek day = (DaysOfWeek)Enum.GetValues(typeof(DaysOfWeek)).GetValue(numberOfDay - 1);
        Console.WriteLine($"{day}");
    }
}


