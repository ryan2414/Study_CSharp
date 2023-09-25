namespace HelloWorld
{
    // OOP(은닉성/상속성/다형성)

    class Knight
    {
        private int hp;

        public void SetHp(int hp)
        {
            this.hp = hp;
        }

        public void SecretFunction()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.SetHp(100);
            knight.SecretFunction();
        }
    }
}