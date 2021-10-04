using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClassLibrary
{
    public class ButtonFunctions
    {
        public static bool SaveFile(string path, string content)
        {
            if (path.EndsWith(".json"))
            {
            
                if (!string.IsNullOrWhiteSpace(content))
                {
                    if ((content.Trim().StartsWith("{") && content.Trim().EndsWith("}")) ||
                        (content.Trim().StartsWith("[") && content.Trim().EndsWith("]")))
                    {
                        try
                        {
                            var obj = JToken.Parse(content);
                            File.WriteAllText(path, content);
                            return true;
                        }
                        catch (JsonReaderException)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                File.WriteAllText(path, content);
                return true;
            }
        }
        public static bool UpdateFile(string path, string content)
        {
            if (path.EndsWith(".json"))
            {
                if (!string.IsNullOrWhiteSpace(content))
                {
                    if ((content.Trim().StartsWith("{") && content.Trim().EndsWith("}")) ||
                        (content.Trim().StartsWith("[") && content.Trim().EndsWith("]")))
                    {
                        try
                        {
                            var obj = JToken.Parse(content);
                            File.WriteAllText(path, content);
                            return true;
                        }
                        catch (JsonReaderException)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else 
                {
                    return false;
                }
            }
            else
            {
                File.WriteAllText(path, content);
                return true;
            }
        }
        public static string IndentJSON(string content) 
        {
            try
            {
                return JToken.Parse(content).ToString(Formatting.Indented);
            }
            catch 
            {
                return content;
            }
        }
    }
}
