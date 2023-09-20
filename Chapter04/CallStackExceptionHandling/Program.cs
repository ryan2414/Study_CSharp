using Packt;
using static System.Console;

WriteLine("In Main");
Alpha();

static void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

static void Beta()
{
    WriteLine("In Beta");
    try
    {
        Calculator.Gamma();

    }
    catch (Exception e)
    {
        WriteLine($"Caught this: {e.Message}");
        //throw e;
    }
}