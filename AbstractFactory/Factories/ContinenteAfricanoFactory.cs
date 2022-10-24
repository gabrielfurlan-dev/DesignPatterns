using AbstractFactory.Entities;
using AbstractFactory.Entities.Animais;

namespace AbstractFactory.Factories
{
    public class ContinenteAfricanoFactory : IContinenteFactory
    {
        public Carnivoro CriarAnimalCarnivoro()
            => new Leao();

        public Herbivoro CriarAnimalHerbivoro()
            => new BoiCavalo();
    }
}