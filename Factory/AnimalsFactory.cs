using Animals;

namespace Factory
{
    public class AnimalsFactory
    {
        public static IAnimals GetAnimal(string TypeAnimals,
                                        string Name,
                                        string NickName,
                                        int Age)
        {
            switch (TypeAnimals)
            {
                case "Mammals": return new Mammals(TypeAnimals, Name, NickName, Age);
                case "Birds": return new Birds(TypeAnimals, Name, NickName, Age);
                case "Amphibians": return new Amphibians(TypeAnimals, Name, NickName, Age);

                default: return new NewTypeAnimals(TypeAnimals, Name, NickName, Age);

            }
        }
    }
}
