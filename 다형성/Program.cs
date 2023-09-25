using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    // 다형성
    // 클래스 형식 변환
    // 
    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            System.Console.WriteLine("Player Move");
        }
    }

    class Knight : Player
    {
        public override void Move()
        {
            System.Console.WriteLine("Knight Move");
        }
    }

    class Mage : Player
    {
        public int mp;
        public override void Move()
        {
            System.Console.WriteLine("Mage Move");
        }
    }
    
    class Program
    {
        static void EnterGame(Player player)
        {
            Mage mage2 = player as Mage;
            if (mage2 != null)
            {
                mage2.mp -= 10;
                mage2.Move();
            }

            Knight knight = (player as Knight);
            if (knight != null)
            {
                knight.Move();
            }
            // bool isMage = player is Mage;
            // if (isMage)
            // {
            //     Mage mage = (Mage)player;
            //     mage.mp = 10;
            // }

        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();
            mage.Move();

            Player magePlayer = mage;
            Mage mage2 = (Mage)magePlayer;

            EnterGame(knight);
            EnterGame(mage);
        }
    }
}