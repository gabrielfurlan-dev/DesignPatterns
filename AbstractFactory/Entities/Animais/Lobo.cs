namespace AbstractFactory.Entities.Animais
{
    public class Lobo : Carnivoro
    {
        internal override void Comer(Herbivoro herbivoro)
        => Console.WriteLine(this.GetType().Name + " come " + herbivoro.GetType().Name);
    }
}