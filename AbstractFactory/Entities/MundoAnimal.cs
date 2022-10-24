using AbstractFactory.Factories;

namespace AbstractFactory.Entities
{

    public class MundoAnimal
    {
        private Herbivoro _herbivoro;
        private Carnivoro _carnivoro;

        public MundoAnimal(IContinenteFactory continente)
        {
            _carnivoro = continente.CriarAnimalCarnivoro();
            _herbivoro = continente.CriarAnimalHerbivoro();
        }

        public void ExecutarCadeiaAlimentar()
        => _carnivoro.Comer(_herbivoro);
    }
}