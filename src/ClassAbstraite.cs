namespace src;

abstract class Mammifere
{
    public int numberOfLegs = 4;
    public int numberOfEars = 2;
}

class Dog : Mammifere
{
    public Dog()
    {

    }

    public void Bark()
    {
        Console.WriteLine("Woof");
    }

    
}

class Program
{
    public static void Main()
    {
        Mammifere billy = new Dog();

        Console.WriteLine(billy.numberOfLegs); // Answer : 4

        billy.Bark();

        Mammifere mammifere = new Mammifere(); // CS0144 : Impossible de créer une instance du type abstract ou de l'interface Mammifere 
    }
}