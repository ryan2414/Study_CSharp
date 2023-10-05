class Program
{
    class MyList<T> where T : struct
    {
        T[] arr = new T[10];

        public T GetItem(int i)
        {
            return arr[i];
        }
    }

    static void Test<T>(T input)
    {

    }
    
    static void Main(string[] args)
    {
        MyList<int> myIntList = new MyList<int>();
        int item = myIntList.GetItem(0);


        MyList<short> myShortList = new MyList<short>();

        Test<int>(3);
    }
}