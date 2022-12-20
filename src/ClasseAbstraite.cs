namespace src.ClasseAbstraite;

abstract class Mammifere
{
    public int NMembre { get; }

    public Mammifere(int nMembre)
    {
        this.NMembre = nMembre;
    }

    public abstract void MakeSound(); // Méthode à implémenter dans les classes enfant
}

class Dog : Mammifere
{
    public Dog(int nMembre) : base(nMembre) {}
    
    public override void MakeSound()
    {
        Console.WriteLine("Dog goes Woof");
    }
}

class Program
{
    public static void Main()
    {
        Mammifere dog = new Dog(4);

        dog.MakeSound();
    }
}
