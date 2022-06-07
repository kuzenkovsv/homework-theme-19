using Animals;
using Factory;
using Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF
{
    class Presenter
    {
        public Model model;
        private IView view;

        public Presenter(IView View)
        {
            this.view = View;
            model = new Model();
        }

        public void AddAnimal()
        {
            model.otherZOO.Add(AnimalsFactory.GetAnimal(view.AnimalType, view.AnimalName, view.AnimalNickName, view.AnimalAge));
        }

        public void DelAnimal()
        {
            model.otherZOO.AnimalsZoo.Remove(view.selectedAnimal);
        }

        public void SaveJson()
        {
            FormatJSON saveToJSON = new FormatJSON("FormatJSON");
            SaveZoo sz = new SaveZoo(saveToJSON);
            sz.Save(model.otherZOO, $"{model.otherZOO.NameZoo}.json");

            MessageBox.Show($"Файл сохранён под именем - {model.otherZOO.NameZoo}.json",
                "Успешное сохранение",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        public void SaveXml()
        {
            FormatXML saveToXML = new FormatXML("FormatXML");

            SaveZoo sz = new SaveZoo(saveToXML);

            ZooXml otherZOOxml = new ZooXml();
            otherZOOxml.NameZoo = model.otherZOO.NameZoo;

            foreach (var item in model.otherZOO.AnimalsZoo)
            {
                otherZOOxml.AnimalsZoo.Add(GetAnimalXml(item.TypeAnimals, item.Name, item.NickName, item.Age));
            }

            sz.Save(otherZOOxml, $"{otherZOOxml.NameZoo}.xml");

            MessageBox.Show($"Файл сохранён под именем - {model.otherZOO.NameZoo}.xml",
                "Успешное сохранение",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        public void Exit()
        {
            System.Windows.Application.Current.MainWindow.Close();
        }
        
        public static AnimalsZOO GetAnimalXml(string TypeAnimals, string Name, string NickName, int Age)
        {
            switch (TypeAnimals)
            {
                case "Млекопитающие": return new Mammals(TypeAnimals, Name, NickName, Age);
                case "Птицы": return new Birds(TypeAnimals, Name, NickName, Age);
                case "Земноводные": return new Amphibians(TypeAnimals, Name, NickName, Age);

                default: return new NewTypeAnimals(TypeAnimals, Name, NickName, Age);

            }
        }

    }
}
