using AbstractFactory.Entities;
using AbstractFactory.Entities.Animais;

namespace AbstractFactory.Factories
{
    public class ContinenteAmericanoFactory : IContinenteFactory
    {
        public Carnivoro CriarAnimalCarnivoro()
            => new Lobo();

        public Herbivoro CriarAnimalHerbivoro()
            => new Bison();
    }
}