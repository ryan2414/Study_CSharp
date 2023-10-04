class Program
{
    class Monster
    {
        public int id;
        public Monster(int id)
        {
            this.id = id;
        }

    }
    static void Main(string[] args)
    {
        // HashTable
        // Key -> Value

        Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
        for (int i = 0; i < 10000; i++)
        {
            dic.Add(i, new Monster(i));
        }

        Monster mon;
        bool found = dic.TryGetValue(5000, out mon);

        dic.Remove(777);
    }
}