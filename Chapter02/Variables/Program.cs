object height = 1.88;
object name = "Amir";
Console.WriteLine($"{name} is {height} metres tall.");
//int length1 = name.Length;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

dynamic anotherName = "Ahmed";
//dynamic somthing = 12;
dynamic somthing = new[] { 3, 5, 7 };
Console.WriteLine($"Length is {somthing.Length}");