class Program
{
    class Monster
    {
        public int Id {get; set;}
    }
    static void Main(string[] args)
    {
        // Nullable -> Null + able
        int? number = null;

        int b = number ?? 0;

        //number = 3;

        if (number.HasValue)
        {
            int a = number.Value;
            System.Console.WriteLine(a);
        }

        Monster monster = null;
        
        if (monster != null)
        {
            int monsterId = monster.Id;
        }

        int? id = monster?.Id;

    }
}