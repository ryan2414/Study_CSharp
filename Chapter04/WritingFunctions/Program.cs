using static System.Console;

//TimeTable(6);
//decimal taxToPay = CalculateTax(149, "FR");
//WriteLine($"You must pay {taxToPay} in tax.");
//RunCardinalToOrdinal();
RunFactorial();


static void TimeTable(byte number)
{
    WriteLine($"This is the {number} times table:");
    for (int row = 0; row <= 12; row++)
    {
        WriteLine($"{row} * {number} = {row * number}");
    }
    WriteLine();
}

static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
{
    decimal rate = 0.0m;
    switch (twoLetterRegionCode)
    {
        case "CH":
            rate = 0.08m;
            break;
        case "DK":
        case "NO":
            rate = 0.25m;
            break;
        case "GB":
        case "FR":
            rate = 0.2m;
            break;
        case "HU":
            rate = 0.27M;
            break;
        case "OR":
        case "AK":
        case "MT":
            rate = 0.0m;
            break;
        case "ND":
        case "WI":
        case "ME":
        case "VA":
            rate = 0.05m;
            break;
        case "CA":
            rate = 0.0825m;
            break;
        default:
            rate = 0.06m;
            break;
    }
    return amount * rate;
}

static string CardinalToOrdinal(int number)
{
    switch(number)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}

static void RunCardinalToOrdinal()
{
    for (int number = 1; number <= 40; number++)
    {
        Write($"{CardinalToOrdinal(number)} ");
    }
    WriteLine();
}

static int Factorial(int number)
{
    if (number < 1)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked
        {
        return number * Factorial(number - 1);

        }
    }
}

static void RunFactorial()
{
    for (int i = 0; i < 15; i++)
    {
        WriteLine($"{i}! = {Factorial(i):N0}");
    }
}