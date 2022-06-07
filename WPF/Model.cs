using Animals;
using Factory;
using Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    class Model
    {
        public Zoo otherZOO;

        public Model() 
        {
            string name = "Синильга";
            otherZOO = ZooFactory.GetZoo(name, 10);

            otherZOO.Add(AnimalsFactory.GetAnimal("Пресмыкающиеся", "Ушастая круглоголовка", "Инокентий", 2));

        }

    }
}
