namespace HelloWorld
{
    // 다형성
    // 클래스 형식 변환
    // 
    class Player
    {
        protected int hp;
        protected int attack;
    }
    class Knight : Player
    {

    }
    class Mage : Player
    {
        public int mp;
    }
    class Program
    {
        static void EnterGame(Player player)
        {
            Mage mage2 = player as Mage;
            if (mage2 != null)
            {

            }

            bool isMage = player is Mage;
            if (isMage)
            {
                Mage mage = (Mage)player;
                mage.mp = 10;
            }

        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            Player magePlayer = mage;
            Mage mage2 = (Mage)magePlayer;

            EnterGame(knight);
            EnterGame(mage);
        }
    }
}