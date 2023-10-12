using Global;
using static Global.Util;

namespace Global.JVM;

public class Class1
{
    public static int Add2(int a, int b)
    {
        Util.Print(new { a = b, b = b });
        return a + b;
    }
}