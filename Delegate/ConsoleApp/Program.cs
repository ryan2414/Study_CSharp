class Program
{
    // 업체 사장 - 사장님의 비서
    // 우리의 연락처/용건 거꾸로 -> 연락을 달라고


    // delegate -> 형식은 형식인데, 함수를 자체를 인자로 넘겨 주는 것
    // 반환 int, 입력 void
    // OnClicked 이 delegate 형식의 이름이다.

    delegate int OnClicked();


    // UI
    static void ButtonPressed(OnClicked clickedFunction/* 함수 자체를 인자로 넘김 */)
    {
        // 함수를 호출();
        clickedFunction();
    }

    static int TestDelegate()
    {
        System.Console.WriteLine("Hello Delegate");
        return 0;
    }

    static int TestDelegate2()
    {
        System.Console.WriteLine("Hello Delegate2");
        return 0;
    }

    static void Main(string[] args)
    {
        // delegate(대리자)

        OnClicked clicked = new OnClicked(TestDelegate);
        clicked += TestDelegate2;

        clicked();

        ButtonPressed(TestDelegate);
    }
}