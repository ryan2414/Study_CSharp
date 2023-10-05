class Program
{
    // 객체지향 -> 은닉성
    // 불필요한 정보를 노출하지 않음

    class Knight
    {
        private int hp;

        public int HP
        {
            get { return hp; }
            set { this.hp = value; }
        }

        public int HP2 { get; private set; } = 100;

        // Getter Get함수
        public int GetHp() { return hp; }
        // Setter Set함수
        public void SetHp(int hp) { this.hp = hp; }
    }

    static void Main(string[] args)
    {
        Knight knight = new Knight();
        knight.HP = 100;
        int hp = knight.HP;
    }
}