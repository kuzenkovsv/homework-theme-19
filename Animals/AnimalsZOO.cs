using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public interface IAnimals
    {
        /// <summary>
        /// Тип животного
        /// </summary>
        string TypeAnimals { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Кличка
        /// </summary>
        string NickName { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        int Age { get; set; }

    }

    public abstract class AnimalsZOO : IAnimals
    {
        static int counter;

        static AnimalsZOO() { counter = 1; }

        /// <summary>
        /// Непараметризированный конструктор
        /// </summary>
        public AnimalsZOO() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        public AnimalsZOO(string TypeAnimals, string Name, string NickName, int Age)
        {
            this.TypeAnimals = TypeAnimals;
            this.Name = Name;
            this.NickName = NickName + $" {counter}";
            this.Age = Age;

            counter++;
        }

        /// <summary>
        /// Тип животного
        /// </summary>
        public string TypeAnimals { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Кличка
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Расходы на питание
        /// </summary>
        /// <returns></returns>
        public abstract decimal FoodExpenses();

        public override string ToString()
        {
            return $"{this.TypeAnimals,-30} {this.Name,-30} {this.NickName,-30} {this.Age,-3}";
        }
    }

    public class Amphibians : AnimalsZOO
    {
        static int counter;

        static Amphibians() { counter = 1; }

        /// <summary>
        /// Непараметризированный конструктор
        /// </summary>
        public Amphibians() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Amphibians(string TypeAnimals, string Name, string NickName, int Age)
        {
            this.TypeAnimals = TypeAnimals;
            this.Name = Name;
            this.NickName = NickName + $" {counter}";
            this.Age = Age;

            counter++;
        }


        /// <summary>
        /// Расходы на питание
        /// </summary>
        /// <returns></returns>
        public override decimal FoodExpenses()
        {
            return 123;
        }
    }

    public class Birds : AnimalsZOO
    {
        static int counter;

        static Birds() { counter = 1; }

        /// <summary>
        /// Непараметризированный конструктор
        /// </summary>
        public Birds() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Birds(string TypeAnimals, string Name, string NickName, int Age)
        {
            this.TypeAnimals = TypeAnimals;
            this.Name = Name;
            this.NickName = NickName + $" {counter}";
            this.Age = Age;

            counter++;
        }


        /// <summary>
        /// Расходы на питание
        /// </summary>
        /// <returns></returns>
        public override decimal FoodExpenses()
        {
            return 123;
        }
    }

    public class Mammals : AnimalsZOO
    {
        static int counter;

        static Mammals() { counter = 1; }

        /// <summary>
        /// Непараметризированный конструктор
        /// </summary>
        public Mammals() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Mammals(string TypeAnimals, string Name, string NickName, int Age)
        {
            this.TypeAnimals = TypeAnimals;
            this.Name = Name;
            this.NickName = NickName + $" {counter}";
            this.Age = Age;

            counter++;
        }


        /// <summary>
        /// Расходы на питание
        /// </summary>
        /// <returns></returns>
        public override decimal FoodExpenses()
        {
            return 123;
        }
    }

    public class NewTypeAnimals : AnimalsZOO
    {
        static int counter;

        static NewTypeAnimals() { counter = 1; }

        /// <summary>
        /// Непараметризированный конструктор
        /// </summary>
        public NewTypeAnimals() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        public NewTypeAnimals(string TypeAnimals, string Name, string NickName, int Age)
        {
            this.TypeAnimals = TypeAnimals;
            this.Name = Name;
            this.NickName = NickName + $" {counter}";
            this.Age = Age;

            counter++;
        }


        /// <summary>
        /// Расходы на питание
        /// </summary>
        /// <returns></returns>
        public override decimal FoodExpenses()
        {
            return 123;
        }
    }
}
