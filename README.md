# Tutoriel Héritage et Polymorphisme

## 1. L'héritage

**L'héritage** permet de définir une **classe enfant** qui réutilise (hérite), étend ou modifie le comportement d'une **classe parente**. En d'autres termes c'est une **spécialisation de la classe parente**.

```cs
class FootballPlayer
{
    string name;

    public FootballPlayer(string name)
    {
        this.name = name;
    }

    public void ShootBall()
    {
        Console.WriteLine("{0} shoots the ball.", this.name);
    }

}

class GoalKeeper : FootballPlayer
{
    public GoalKeeper(string name) : base(name)
    {
    }

    public void TakeBall()
    {
        Console.WriteLine("{0} takes the ball in his hands.", this.name);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        GoalKeeper goalKeeper = new GoalKeeper("Hugo Lloris");

        goalKeeper.TakeBall();  // Return : "Hugo Lloris takes the ball in his hands."
        goalKeeper.ShootBall(); // Return : "Hugo Lloris shoots the ball."
    }
}
```

## 2. Les classes abstraites

Une **classe abstraite** est une classe possédant ses propres attributs et méthodes, mais qu'il n'est **pas possible d'instancier**. En revanche, elle **peut être héritée** par des classes enfants, qui récupèreront toutes ses propriétés.

### Création d'une classe abstraite

```cs

```

## 3. Les interfaces

En programmation orientée objet, **une interface** est une classe non instanciable qui déclare un ensemble de méthodes. Ces méthodes devront être implémentées dans les classes qui héritent de l'interface.

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







## Polymorphisme

Le polymorphisme permet de manipuler des objets sans connaître tout à fait leur type.

De façon générale, le polymorphisme est le fait qu'un même code puisse s'adapter automatiquement aux types des données qu'ils s'appliquent.


## Méthodes Abstraites

### Définition

 Une méthode abstraite déclare un comportement sans le définir. Elle doit être redéfinie dans toutes les classes dérivées (par le mot clé @override). 


Idée intuitive :
Définir des concepts abstraits
Pour lesquels on ne peut pas directement définir des objets
mais qui peuvent être préciser dans les classes héritières.

Virtual

Le rôle de “virtual” est de signaler au compilateur
- que les classes héritières de ces classes virtuelles
nécessitent un traitement spécial
- suppression des classes ancêtres “en double” 

Surcharge

La surcharge offre la possibilité de définir
- des méthodes homonynes
(même nom et mêmes paramètres)
pour des objets de type différents. 

**Références :**
https://stackoverflow.com/questions/1031273/what-is-polymorphism-what-is-it-for-and-how-is-it-used

https://ufrsciencestech.u-bourgogne.fr/licence2/ARCHIVES/i4a/I4a_cm3.pdf

---
Explication du code, voir le code Polymorph.cs :

**Voici un exemple en C#**:
- Créez quatre classes dans une application console :

Dans cet exemple, nous créons une liste de la classe de base Véhicule, qui ne sait pas combien de roues possède chacune de ses sous-classes, mais qui sait que chaque sous-classe est chargée de savoir combien de roues elle possède.

Nous ajoutons ensuite une bicyclette, une voiture et un camion à la liste.

Ensuite, nous pouvons parcourir en boucle chaque véhicule de la liste et les traiter tous de manière identique, mais lorsque nous accédons à la propriété "roues" de chaque véhicule, la classe Véhicule délègue l'exécution de ce code à la sous-classe correspondante.

Ce code est dit polymorphe, car le code exact qui est exécuté est déterminé par la sous-classe référencée au moment de l'exécution.

Voir plus précisement Polymorph.cs


