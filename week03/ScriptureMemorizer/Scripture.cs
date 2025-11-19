public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.ToString());
        Console.WriteLine(string.Join(" ", _words.Select(w => w.Display())));
    }

    public bool HideRandomWord()
    {
        var hiddenWords = _words.Where(w => !w.IsHidden).ToList();
        if (hiddenWords.Count == 0) return false;

        Random rand = new Random();
        var randomIndex = rand.Next(hiddenWords.Count);
        hiddenWords[randomIndex].Hide();
        return true;
    }

    public bool AllHidden => _words.All(w => w.IsHidden);
}
