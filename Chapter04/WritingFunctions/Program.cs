using static System.Console;

//TimeTable(6);
//decimal taxToPay = CalculateTax(149, "FR");
//WriteLine($"You must pay {taxToPay} in tax.");
//RunCardinalToOrdinal();
//RunFactorial();
RunFibImperative();

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

/// <summary>
/// 32비트 정수를 서수로 변환한다.
/// </summary>
/// <param name="number">1, 2, 3과 같은 기수</param>
/// <returns>1st, 2nd, 3rd와 같은 서수</returns>
static string CardinalToOrdinal(int number)
{
    switch (number)
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
        try
        {
            WriteLine($"{i}! = {Factorial(i):N0}");

        }
        catch (System.OverflowException)
        {
            WriteLine($"{i}! is too big for a 32-bit integer.");
        }
    }
}

static int FibImperative(int term)
{
    if (term == 1)
    {
        return 0;
    }
    else if (term == 2)
    {
        return 1;
    }
    else
    {
        return FibImperative(term - 1) + FibImperative(term - 2);
    }
}

static void RunFibImperative() {
    for (int i = 0; i <= 30; i++) {
        WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.", CardinalToOrdinal(i), FibImperative(i));
    }
}