using Animals;
using System;
using System.Collections.Generic;

namespace Factory
{
    public class ZooFactory
    {
        static Random r;
        static ZooFactory() { r = new Random(); }

        static List<string> mammalsAnimals = new List<string>()
        {
            "Лисица",
            "Волк",
            "Ёж",
            "Бобр",
            "Лев",
            "Медведь",
            "Гепард",
            "Жираф",
            "Рысь",
            "Лань",
            "Калибара",
            "Кабан",
            "Бегемот",
            "Енот",
            "Пума",
            "Утконос",
            "Песец",
            "Выдра",
            "Зебра",
            "Белка"
        };

        static List<string> birdsAnimals = new List<string>()
        {
            "Аист",
            "Баклан",
            "Беркут",
            "Ворон",
            "Выпь",
            "Глухарь",
            "Голубь",
            "Грач",
            "Дятел",
            "Журавль",
            "Кречет",
            "Кукушка",
            "Лебедь",
            "Рябчик",
            "Сапсан",
            "Сова",
            "Сыч",
            "Сокол",
            "Цапля",
            "Чайка"
        };

        static List<string> amphibiansAnimals = new List<string>()
        {
            "Гребенчатый тритон",
            "Сибирский углозуб",
            "Озёрная лягушка",
            "Обыкновенный тритон",
            "Травяная лягушка",
            "Обыкновенная жаба",
            "Обыкновенная чесночница",
            "Краснобрюхая жерлянка",
            "Остромордая лягушка",
            "Прудовая лягушка",
            "Зелёная жаба",
            "Камышовая жаба",
            "Сибирская лягушка",
            "Съедобная лягушка",
            "Малоазиатский тритон",
            "Кавказская жаба",
            "Кавказская крестовка",
            "Монгольская жаба",
            "Дальневосточная квакша",
            "Малоазиатская лягушка"
        };


        public static Zoo GetZoo(string nameZOO, int Count)
        {
            Zoo zoo = new Zoo(nameZOO);

            for (int i = 0; i < Count; i++)
            {
                switch (r.Next(3))
                {
                    case 1:
                        string name1 = mammalsAnimals[r.Next(mammalsAnimals.Count)];
                        zoo.Add(new Mammals(
                        "Млекопитающие",
                        $"{name1}",
                        $"{name1}",
                        r.Next(1, 4))); break;
                    case 2:
                        string name2 = birdsAnimals[r.Next(birdsAnimals.Count)];
                        zoo.Add(new Birds(
                        "Птицы",
                        $"{name2}",
                        $"{name2}",
                        r.Next(1, 4))); break;
                    default:
                        string name3 = amphibiansAnimals[r.Next(amphibiansAnimals.Count)];
                        zoo.Add(new Amphibians(
                        "Земноводные",
                        $"{name3}",
                        $"{name3}",
                        r.Next(1, 4))); break;
                }
            }

            return zoo;
        }

    }
}
