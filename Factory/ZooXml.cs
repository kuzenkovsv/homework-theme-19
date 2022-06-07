using Animals;
using System.Collections.ObjectModel;
using static System.Console;

namespace Factory
{
    public class ZooXml : BindableBase
    {

        /// <summary>
        /// Название зоопарка
        /// </summary>
        public string NameZoo { get; set; }

        private ObservableCollection<AnimalsZOO> animalsZoo = new ObservableCollection<AnimalsZOO>();
        public ObservableCollection<AnimalsZOO> AnimalsZoo
        {
            get
            {
                return animalsZoo;
            }
            set
            {
                animalsZoo = value;
                OnPropertyChanged(nameof(animalsZoo));
            }
        }

        /// <summary>
        /// Свойство для получения информации
        /// </summary>
        public AnimalsZOO this[int element]
        {
            get { return AnimalsZoo[element]; }
            set { AnimalsZoo[element] = value; }
        }

        public ZooXml() { }

        public ZooXml(string NameZoo)
        {
            this.NameZoo = NameZoo;
            this.AnimalsZoo = new ObservableCollection<AnimalsZOO>();
        }

        public void Add(AnimalsZOO animal)
        {
            AnimalsZoo.Add(animal);
        }

        public void PrintZoo()
        {
            foreach (var e in AnimalsZoo)
            {
                WriteLine(e.ToString());
            }
        }
    }
}
