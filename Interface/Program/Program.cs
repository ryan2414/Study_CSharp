class Program
{
    abstract class Monster
    {
        public abstract void Shout();
    }

    interface IFlyable
    {
        public abstract void Fly();
    }

    class Orc : Monster
    {
        public override void Shout()
        {
            System.Console.WriteLine("록타르 오가르!");
        }
    }

    class FlyableOrc : Orc, IFlyable
    {
        public void Fly()
        {
            System.Console.WriteLine("날아!");
        }
    }

    class Skeleton : Monster
    {
        public override void Shout()
        {
            System.Console.WriteLine("꾸에에엑!");
        }
    }

    // 다중 상속을 막는 이유...
    // 죽음의 다이아몬드
    // 상속 받은 것 중 어느 함수를 실행해야 되나 

    static void DoFly(IFlyable flyable)
    {

    }
    static void Main(string[] args)
    {
        IFlyable flyable = new FlyableOrc();
        FlyableOrc flyable2 = new FlyableOrc();
        DoFly(flyable);
        DoFly(flyable2);
    }
}