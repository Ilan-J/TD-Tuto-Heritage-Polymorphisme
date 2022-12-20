namespace src;

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
