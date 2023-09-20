using Packt.Shared;
using static System.Console;
using System;

Person bob = new();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);

WriteLine("{0} was born on {1:dddd, d MMMM yyyy}", bob.Name, bob.DateOfBirth );

var alice = new Person
{
    Name = "Alice Jones",
    DateOfBirth = new DateTime(1998, 3, 7)
};
WriteLine("{0} was born on {1:dd MMM yy}", alice.Name, alice.DateOfBirth);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine("{0}'s favorite wonder is {1}. Its integer is {2}", bob.Name, bob.FavoriteAncientWonder, (int)bob.FavoriteAncientWonder);

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
//bob.BucketList = (WondersOfTheAncientWorld)18;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new Person { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int child = 0;child < bob.Children.Count;child++)
{
    WriteLine($" {bob.Children[child].Name}");
}

BankAccount.InterestRate = 0.012m;
var jonesAccount = new BankAccount();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine("{0} earned {1:C} interest.", jonesAccount.AccountName, jonesAccount.Balance * BankAccount.InterestRate);
var gerrierAccount = new BankAccount();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine("{0} earned {1:C} interest.", gerrierAccount.AccountName, gerrierAccount.Balance * BankAccount.InterestRate);

WriteLine($"{bob.Name} is a {Person.Species}");

WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

WriteLine();

Person blankPerson = new();
WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.", blankPerson.Name, blankPerson.HomePlanet, blankPerson.Instantiated);

WriteLine();
Person gunny = new(initalName: "Gunny", homePlanet: "Mars");
WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.", gunny.Name, gunny.HomePlanet, gunny.Instantiated);

WriteLine();
bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine();
(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

WriteLine();
var fruitNamed = bob.GetNamedFruit();
WriteLine($"{fruitNamed.Name}, {fruitNamed.Number} there are.");

WriteLine();
var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

WriteLine();
(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

WriteLine();
var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");
var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}" +
    $"");