# Tutoriel Héritage et Polymorphisme

Addendum : Ce tutoriel a été réalisé pour le développement en C#.

## 1. L'héritage

**L'héritage** permet de définir une **classe enfant** qui réutilise (hérite),
étend ou modifie le comportement d'une **classe parente**.
En d'autres termes c'est une **spécialisation de la classe parente**.

Une classe enfant **n'hérite pas des propriétés privées** de la classe parente.

### Comment créer un héritage

```cs
// Classe parente
class FootballPlayer
{
    // Méthodes et propriétés 
}

// Classe enfant héritant de FootballPlayer
class GoalKeeper : FootballPlayer
{
    // Méthodes et propriétés de GoalKeeper et FootballPlayer
}
```

### Héritage à plusieurs niveaux

Une classe peut être dérivée d'une autre classe dérivée. Cet héritage peut avoir autant de niveaux que désirés.

```cs
// Classe parente
class Mammifere
{
    // Méthodes et propriétés 
}

class Felin : Mammifere
{
    // Méthodes et propriétés de Felin et Mammifere
}

class Chat : Felin
{
    // Méthodes et propriétés de Chat, Felin et donc de Mammifere
}
```

### Les champs protégés

Un membre protégé est accessible dans sa classe et par les instances de la classe dérivée.

```cs
class FootballPlayer
{
    protected string name;
    private string favouriteColor;
}

class GoalKeeper : FootballPlayer
{
    // La classe hérite de la propriété "name" mais pas de la propriété "favouriteColor".
}
```

### Les classes abstraites

Une **classe abstraite** est une classe possédant ses propres attributs et méthodes, mais qui n'est **pas instanciable**.
En revanche, elle **peut être héritée** par des classes enfants, qui récupèreront toutes ses propriétés et méthodes.

### Création d'une classe abstraite

```cs
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
```

### Les interfaces

En programmation orientée objet, **une interface** est une **classe non instanciable qui déclare un ensemble de méthodes**.
Ces méthodes doivent être implémentées dans les classes qui héritent de l'interface.

```cs
interface IReadable
{
    public void TurnPage(int nTurn); // Méthode à implémenter
}

class Book : IReadable
{
    int NPages { get; }
    int CurrentPage { get; set; } = 0;

    public Book(int nPages)
    {
        this.NPages = nPages;
    }

    public void TurnPage(int nTurn) // Implémentation de la méthode
    {
        this.CurrentPage += nTurn;
    }
}
```

### Hériter de plusieurs interfaces

```cs
interface IA
{
}

interface IB
{
}

class Item : IA, IB
{
    // Classe héritant des propriétés des interfaces IA et IB
}
```

## 2. Le polymorphisme

Le polymorphisme permet de manipuler des objets sans connaître tout à fait leur type.

De façon générale, le polymorphisme est le fait qu'un même code puisse s'adapter automatiquement aux types des données qu'ils s'appliquent.

### Méthodes Abstraites

 Une méthode abstraite déclare un comportement sans le définir. Elle doit être redéfinie dans toutes les classes dérivées (par le mot clé @override).

Idée intuitive :
Définir des concepts abstraits
Pour lesquels on ne peut pas directement définir des objets
mais qui peuvent être préciser dans les classes héritières.

### Méthodes virtuelles

Une méthode virtuelle ( virtual ) fournit un comportement par défaut dans une classe.
Elle peut être redéfinie ( override ) dans une classe dérivée.

### La surcharge

La surcharge offre la possibilité de définir

- des méthodes homonynes
(même nom et mêmes paramètres)
pour des objets de type différents.

**Références :**

[What is Polymorphism](https://stackoverflow.com/questions/1031273/what-is-polymorphism-what-is-it-for-and-how-is-it-used)

[Guide POO](https://ufrsciencestech.u-bourgogne.fr/licence2/ARCHIVES/i4a/I4a_cm3.pdf)

---
Explication du code, voir le code Polymorph.cs :

**Voici un exemple en C#**:

- Créez quatre classes dans une application console :

Dans cet exemple, nous créons une liste de la classe de base Véhicule, qui ne sait pas combien de roues possède chacune de ses sous-classes, mais qui sait que chaque sous-classe est chargée de savoir combien de roues elle possède.

Nous ajoutons ensuite une bicyclette, une voiture et un camion à la liste.

Ensuite, nous pouvons parcourir en boucle chaque véhicule de la liste et les traiter tous de manière identique, mais lorsque nous accédons à la propriété "roues" de chaque véhicule, la classe Véhicule délègue l'exécution de ce code à la sous-classe correspondante.

Ce code est dit polymorphe, car le code exact qui est exécuté est déterminé par la sous-classe référencée au moment de l'exécution.

Voir plus précisement Polymorph.cs

```cs
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
```
