int numberOfApples = 12;
decimal pricePerApple = 0.35M;
Console.WriteLine("{0} apples consts {1:C}", numberOfApples, pricePerApple * numberOfApples);
string formatted = string.Format("{0} apples costs {1:C}", numberOfApples, pricePerApple * numberOfApples);