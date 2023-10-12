using Global;
using static Global.Util;

namespace Global.JVM;

public class Class1
{
    public static int Add2(int a, int b)
    {
        Util.Print(new { a = a, b = b });
        return a + b;
    }
}