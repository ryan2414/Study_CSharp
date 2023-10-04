class Program
{

    static int GetHighestScore(int[] scores)
    {
        int maxValue = 0;

        foreach (int score in scores)
        {
            if (score >= maxValue)
            {
                maxValue = score;
            }
        }

        return maxValue;
    }

    static int GetAverageScore(int[] scores)
    {
        if (scores.Length == 0)
        {
            return 0;
        }

        int sum = 0;

        foreach (int score in scores)
        {
            sum += score;
        }
        return sum / scores.Length;
    }

    static int GetIndexOf(int[] scores, int value)
    {
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    static void Sort(int[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            // i ~ score.Length -1 중 제일 작은 숫자가 있는 인덱스를 찾는다
            int minIndex = i;
            for (int j = i; j < args.Length; j++)
            {
                if (args[j] < args[minIndex])
                {
                    minIndex = j;
                }
            }
            
            // swap
            int temp = args[i];
            args[i] = args[minIndex];
            args[minIndex] = temp;
            
        }
    }

    static void Main(string[] args)
    {
        int[] scores = new int[5] { 10, 30, 40, 20, 50 };

        int highestScore = GetHighestScore(scores);
        System.Console.WriteLine(highestScore);

        int avgScore = GetAverageScore(scores);
        System.Console.WriteLine(avgScore);

        int index = GetIndexOf(scores, 20);
        System.Console.WriteLine(index);

        Sort(scores);
    }
}