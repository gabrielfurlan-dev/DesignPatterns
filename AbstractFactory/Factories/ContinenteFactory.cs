using AbstractFactory.Entities;

namespace AbstractFactory.Factories
{
    public interface IContinenteFactory
    {
         public abstract Herbivoro CriarAnimalHerbivoro();
         public abstract Carnivoro CriarAnimalCarnivoro();
    }
}