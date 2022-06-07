using Animals;
using Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        Presenter p;

        public string AnimalType { get => cbAnimalType.Text; set => cbAnimalType.Text = value; }
        public string AnimalName { get => textAnimalName.Text; set => textAnimalName.Text = value; }
        public string AnimalNickName { get => textAnimalNickName.Text; set => textAnimalNickName.Text = value; }
        public int AnimalAge { get => Convert.ToInt32(cbAnimalAge.Text); set => cbAnimalAge.SelectedIndex = value + 1; }
        public AnimalsZOO selectedAnimal { get => Animals.SelectedItem as AnimalsZOO; set => Animals.SelectedItem = value; }

        public MainWindow()
        {
            InitializeComponent();

            p = new Presenter(this);

            ZOO.Title = p.model.otherZOO.NameZoo;
            Animals.ItemsSource = p.model.otherZOO.AnimalsZoo;

            JSON.Click += (s, e) => p.SaveJson();
            XML.Click += (s, e) => p.SaveXml();
            Exit.Click += (s, e) => p.Exit();
            Add.Click += (s, e) => p.AddAnimal();
            Del.Click += (s, e) => p.DelAnimal();
        }
    }
}
