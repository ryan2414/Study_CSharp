using static System.Console;

try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incremention: {x}");
        x++;
        WriteLine($"After incremention: {x}");
        x++;
        WriteLine($"After incremention: {x}");

    }

}
catch
{
    WriteLine("오버플로 예외가 발생했지만 여기서 처리했음");
}

unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}
