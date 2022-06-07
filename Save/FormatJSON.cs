using Newtonsoft.Json;
using System.IO;

namespace Save
{
    public class FormatJSON : ISave
    {
        private string nameOfFile;
        public FormatJSON(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
        }

        public void SaveZOO<T>(T СoncreteZOO, string path)
        {
            var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            string json1 = JsonConvert.SerializeObject(СoncreteZOO, Newtonsoft.Json.Formatting.Indented, jset);
            File.WriteAllText(path, json1);
        }
    }
}
