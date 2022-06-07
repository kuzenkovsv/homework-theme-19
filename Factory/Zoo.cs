using Animals;
using System.Collections.ObjectModel;
using static System.Console;

namespace Factory
{
    public class Zoo : BindableBase
    {

        /// <summary>
        /// Название зоопарка
        /// </summary>
        public string NameZoo { get; set; }

        private ObservableCollection<IAnimals> animalsZoo = new ObservableCollection<IAnimals>();
        public ObservableCollection<IAnimals> AnimalsZoo
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
        public IAnimals this[int element]
        {
            get { return AnimalsZoo[element]; }
            set { AnimalsZoo[element] = value; }
        }

        public Zoo() { }

        public Zoo(string NameZoo)
        {
            this.NameZoo = NameZoo;
            this.AnimalsZoo = new ObservableCollection<IAnimals>();
        }

        public void Add(IAnimals animal)
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
