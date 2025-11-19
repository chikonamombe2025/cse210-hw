public class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int Verse { get; private set; }

    public Reference(strpublic class Reference
{ 
    private string Book { get; }
    private int Chapter { get; }
    private List<int> Verses { get; }

    public Reference(string book, int chapter, List<int> verses)
    {
        Book = book;
        Chapter = chapter;
        Verses = verses;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{string.Join("-", Verses)}";
    }
}ing book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public string GetDisplayText()
    {
        return $"{Book} {Chapter}:{Verse}";
    }
}
