// See https://aka.ms/new-console-template for more information
//#error version
using System.Reflection;

// 추가된 어셈블리의 형식을 사용해
// 사용하지 않는 변수를 몇 개 선언한다.
System.Data.DataSet ds;
HttpClient client;

Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) return;
// 이 프로그램이 참조하는 어셈블리를 순회한다.
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    // 세부 정보를 읽기 위해 어셈블리를 로드한다.
    Assembly a = Assembly.Load(name);
    // 전체 메서드 count를 저장할 변수를 선언한다.
    int methodCount = 0;
    // 어셈블리의 모든 형식을 순회한다.
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // 메서드의 개수를 더해서 누적한다.
        methodCount += t.GetMethods().Count();
    }
    // 형식과 메서드의 개수를 출력한다.
    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", arg0: a.DefinedTypes.Count(), arg1 : methodCount, arg2: name.Name);
}

// heightInMetres 변수를 선언하고 1.88로 초기화 한다.
double heightInMetres = 1.88;
Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}");