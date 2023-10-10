using System.Reflection;

class Program
{
    class Important : System.Attribute
    {
        string message;
        public Important(string message) { this.message = message; }
    }
    class Monster
    {
        [Important("Very Important")]//컴퓨터가 런타임에 참조할 수 있는 주석
        public int hp;
        protected int attack;
        private float speed;
    
        void Attack() { }
    }
    static void Main(string[] args)
    {
        // Reflection: X-ray
        Monster monster = new Monster();
        Type type = monster.GetType();

        var fields = type.GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Instance);

        foreach (FieldInfo field in fields)
        {
            string access = "protected";
            if (field.IsPublic)
                access = "public";
            else if (field.IsPrivate)
                access = "private";

            var ATT = field.GetCustomAttributes();
            System.Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");

        }
    }
}