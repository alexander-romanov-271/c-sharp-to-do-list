using System.Reflection;
namespace Utils;

public class Utilities
{
    public static string? TypeToString(object item)
    {
        PropertyInfo[] props = item.GetType().GetProperties();

        Dictionary<string, string> proj = new Dictionary<string, string>();        

        foreach (PropertyInfo prop in props)
        {   
            string name = prop.Name;
            var val = prop.GetValue(item, null);

            if (val is not null)
            {
                proj.Add(name, val.ToString() ?? "");
            }
            else
            {
                proj.Add(name, "");
            }
        }

        string returnString = "";

        foreach (string name in proj.Keys)
        {
            returnString += name + ": " + proj[name] + ";";
        }

        returnString += "";

        return returnString;

    }

    public static Dictionary<string, dynamic> StringToDict(string dictString)
    {
        Dictionary<string, dynamic> d = new Dictionary<string, dynamic>();

        foreach (string s in dictString.Split(';'))
        {
            string key = s.Split(';')[0];
            string value = s.Split(':')[1];
            d[key] = value;
        }

        return d;
    }
}
