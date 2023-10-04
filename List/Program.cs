class Program
{
    static void Main(string[] args)
    {
        // List <- 동적 배열
        List<int> list = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            list.Add(i);
        }

        // 삽입 삭제
        list.Insert(2, 999);
        
        bool sucess = list.Remove(999);
        list.RemoveAt(2);

        foreach (var i in list)
        {
            System.Console.WriteLine(i);
        }
    }
}