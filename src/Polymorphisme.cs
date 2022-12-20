namespace src.Polymorphisme;

public abstract class Vehicle
{
    public abstract int Wheels;
}

public class Bicycle : Vehicle
{
    public override int Wheels()
    {
        return 2;
    }
}

public class Car : Vehicle
{
    public override int Wheels()
    {
        return 4;
    }
}

public class Truck : Vehicle
{
    public override int Wheels()
    {
        return 18;
    }
}
public class Program
{
    public static void Main()
    {
        List<Vehicle> vehicles = new()
        {
            new Bicycle(),
            new Car(),
            new Truck()
        };

        foreach (Vehicle v in vehicles)
        {
            Console.WriteLine("A {0} has {1} wheels.",
                v.GetType().Name,
                v.Wheels);
        }
    }
}
