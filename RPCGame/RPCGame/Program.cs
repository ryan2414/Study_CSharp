namespace RPCGame
{
    internal class Program
    {
        enum RPC
        {
            Scissors,
            Rock,
            Paper,
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            RPC aiChoice = (RPC)rand.Next(0, 2);

            RPC choice = (RPC)Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case RPC.Scissors:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case RPC.Rock:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case RPC.Paper:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case RPC.Scissors:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case RPC.Rock:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case RPC.Paper:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            if (choice ==  aiChoice)
            {
                Console.WriteLine("무승부입니다.");
            }    
            else if (choice == RPC.Scissors && aiChoice == RPC.Paper)
            {
                Console.WriteLine("플레이어의 승리입니다.");
            }
            else if (choice == RPC.Rock && aiChoice == RPC.Scissors)
            {
                Console.WriteLine("플레이어의 승리입니다.");
            }
            else if (choice == RPC.Paper && aiChoice == RPC.Rock)
            {
                Console.WriteLine("플레이어의 승리입니다.");
            }
            else
            {
                Console.WriteLine("플레이어의 패배입니다.");
            }
        }
    }
}