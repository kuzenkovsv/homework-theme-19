using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save
{
    public interface ISave
    {
        void SaveZOO<T>(T СoncreteZOO, string path);
    }

    public class SaveZoo
    {
        public ISave Mode { get; set; }

        public SaveZoo(ISave Method)
        {
            this.Mode = Method;
        }

        public void Save<T>(T СoncreteZOO, string path)
        {
            Mode.SaveZOO(СoncreteZOO, path);
        }
    }
}
