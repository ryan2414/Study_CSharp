﻿// See https://aka.ms/new-console-template for more information

uint naturalNumber = 23;
int integerNumber = -23;
float realNumber = 2.3f;
double anotherRealNumber = 2.3;

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadeciamlNotation = 0x_001E_8480;

Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadeciamlNotation}");

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");


Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if( a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals 0.3");
}
else
{
    Console.WriteLine($"{a} + {b} does Not equals 0.3");
}


Console.WriteLine("Using decimals:");
decimal c = 0.1M;
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals 0.3");
}
else
{
    Console.WriteLine($"{c} + {d} does Not equals 0.3");
}