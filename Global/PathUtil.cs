using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Scriban.Parsing;

namespace Global;

public class PathUtil
{
    public static string[] ExpandWildcard(string path)
    {
        string? dir = Path.GetDirectoryName(path);
        if (string.IsNullOrEmpty(dir)) dir = ".";
        //Util.Print(dir, "dir");
        string fname = Path.GetFileName(path);
        //Util.Print(fname, "fname");
        string[] files = Directory.GetFiles(dir, fname);
        List<string> result = new List<string>();
        for (int i = 0; i < files.Length; i++)
        {
            result.Add(Path.GetFullPath(files[i]));
        }

        return result.ToArray();
    }

    public static string[] ExpandWildcardList(params string[] pathList)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < pathList.Length; i++)
        {
            //Util.Print(pathList[i], "pathList[i]");
            string[] files = ExpandWildcard(pathList[i]);
            result.AddRange(files.ToList());
        }

        return result.ToArray();
    }
}