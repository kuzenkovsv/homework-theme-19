using Animals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Save
{
    public class FormatXML : ISave
    {
        private string nameOfFile;
        public FormatXML(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
        }

        public void SaveZOO<T>(T СoncreteZOO, string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T), new Type[]
                {
                    typeof(AnimalsZOO),
                    typeof(Amphibians),
                    typeof(Birds),
                    typeof(Mammals),
                    typeof(NewTypeAnimals)
                });
                xs.Serialize(stream, СoncreteZOO);
            }
        }
    }
}
