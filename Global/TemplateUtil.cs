namespace Global;

public class TemplateUtil
{
    public static string Render(string text, dynamic parameters)
    {
        var template = Scriban.Template.Parse(text);
        string result = template.Render(parameters);
        return result;
    }
}