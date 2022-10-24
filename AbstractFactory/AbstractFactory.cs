using AbstractFactory.Entities;
using AbstractFactory.Factories;

namespace AbstractFactory;
public class AbstractFactory
{
    public void Main()
    {
        CriarAnimal(new ContinenteAfricanoFactory());
        CriarAnimal(new ContinenteAmericanoFactory());

        Console.ReadKey();
    }

    public void CriarAnimal(IContinenteFactory continente)
    {
        MundoAnimal mundoAnimal = new MundoAnimal(continente);
        mundoAnimal.ExecutarCadeiaAlimentar();
    }
}
