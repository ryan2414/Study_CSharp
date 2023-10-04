class Program
{
    static void Main(string[] args)
    {
        int[] scores = new int[5];
        //int[] scores = new int[];
        scores[0] = 10;
        scores[1] = 20;
        scores[2] = 30;
        scores[3] = 40;
        scores[4] = 50;

        for (int i = 0; i < scores.Length; i++)
        {
            System.Console.WriteLine(scores[i]);
        }

        int[] scores2 = new int[5] { 10, 20, 30, 40, 50 };
        //int[] scores2 = { 10, 20, 30, 40, 50 };

        foreach (int score in scores2)
        {
            System.Console.WriteLine(score);
        }
    }
}