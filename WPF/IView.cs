using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    interface IView
    {

        /// <summary>
        /// Тип животного
        /// </summary>
        string AnimalType { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        string AnimalName { get; set; }

        /// <summary>
        /// Кличка
        /// </summary>
        string AnimalNickName { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        int AnimalAge { get; set; }

        AnimalsZOO selectedAnimal { get; set; }
    }
}
