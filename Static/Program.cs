namespace HelloWorld
{
    // OOP(은닉성/상속성/다형성)

    public class Player
    {
        public static int count; // 오로직 한개만 존재

        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출");
        }

        public Player(int hp)
        {
            this.hp = hp;
            System.Console.WriteLine($"{hp} Player 생성자 호출");
        }

        public void Move()
        {
            System.Console.WriteLine("Move");
        }

        public void Attack()
        {
            System.Console.WriteLine("Attack");

        }

    }

    public class Mage : Player
    {

    }
    public class Archer : Player
    {

    }
    public class Knight : Player
    {
        int c;
        public Knight() : base(100)
        {
            this.c = 10;
            base.id = count;
            count++;

            hp = 100;
            attack = 10;
            Console.WriteLine("Knight 생성자 호출!");
        }

        public void Stun()
        {
            System.Console.WriteLine("Stun Attack");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Move();
        }
    }
}