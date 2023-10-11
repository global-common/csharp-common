using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text.RegularExpressions;

namespace Global;

public class JwrapUtil
{
    public static string PrepareJdk(string url = "https://github.com/java-wrap/jre/releases/download/64bit/openjdk20-20-36.zip")
    {
        string name = UrlToStoreName(url);
        var profilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        //var profilePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData); // C:\ProgramData
        var rootPath = $"{profilePath}\\.jwap\\.jdk";
        Directory.CreateDirectory(rootPath);
        string timestamp = GetTimeStampString();
        string downloadPath = $"{rootPath}\\{name}+{timestamp}.zip";
        string installPath = $"{rootPath}\\{name}";
        if (!Directory.Exists(installPath))
        {
            DownloadBinaryFromUrl(url, downloadPath);
            ZipFile.ExtractToDirectory(downloadPath, $"{installPath}+{timestamp}");
            Directory.Move($"{installPath}+{timestamp}", installPath);
            File.Delete(downloadPath);
        }

        return installPath;
    }

    private static string UrlToStoreName(string url)
    {
        return Regex.Replace(url, "[^a-zA-z0-9-_.]", "!");
    }

    private static string GetTimeStampString()
    {
        var now = DateTime.Now;
        string formatted = now.ToString("yyyy-MMdd-HHmmss-fff");
        return formatted;
    }

    private static void DownloadBinaryFromUrl(string url, string destinationPath)
    {
        WebRequest objRequest = System.Net.HttpWebRequest.Create(url);
        var objResponse = objRequest.GetResponse();
        byte[] buffer = new byte[32768];
        using (Stream input = objResponse.GetResponseStream())
        {
            using (FileStream output = new FileStream(destinationPath, FileMode.CreateNew))
            {
                int bytesRead;
                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}