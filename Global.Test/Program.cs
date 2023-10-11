using System;
using System.Reflection;
using Global;
using static Global.Util;

namespace Global;

public static class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        try
        {
            Print(Environment.Version.ToString(), "Runtime Version");
            Print(Assembly.GetExecutingAssembly().GetName().Version.ToString(), "Assembly Version");
            Print(args, "args");
            Print(Environment.CurrentDirectory);
            var files = PathUtil.ExpandWildcardList("*.exe", "*.dll", "../../../*.cs*", "Global.test.exe");
            Print(files);
        }
        catch (Exception e)
        {
            Log(e.ToString());
        }
    }
}