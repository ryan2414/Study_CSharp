class Program
{
    class Map
    {
        int[,] tiles = {
            {1,1,1,1,1},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,1,1,1,1},
            };

        public void Render()
        {
            var defaultColor = Console.ForegroundColor;
            for (int y = 0; y < tiles.GetLength(1); y++)
            {
                for (int x = 0; x < tiles.GetLength(0); x++)
                {
                    if (tiles[y, x] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;

                    System.Console.Write('\u25cf');
                }
                System.Console.WriteLine();
            }
            Console.ForegroundColor = defaultColor;
        }
    }
    static void Main(string[] args)
    {
        int[] scores = { 10, 20, 30, 40, 50 };

        int[,] arr = new int[2, 3] { { 101, 102, 103 }, { 201, 202, 203 } };

        arr[0, 0] = 1;
        arr[1, 0] = 1;

        Map map = new Map();
        map.Render();

        int[][] a = new int[3][];
        a[0] = new int[3];
        a[1] = new int[6];
        a[2] = new int[2];

        a[0][0] = 1;
    }
}