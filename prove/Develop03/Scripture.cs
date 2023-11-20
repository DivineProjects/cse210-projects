
using System;
class Scripture
{
    

    public string _text;

    private List<Word> words = new List<Word>();

    Reference _reference = new Reference();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        string[] words = _text.Split(' ');
    }



    public void HideRandomWords(int count)
    {
        if (words.Count - CountWordsHidden() < count)
        {
            count = words.Count - CountWordsHidden();
        }

        int hidden = 0;
        Random rand = new Random();
        while (hidden < count)
        {
            int index = rand.Next(words.Count);
            if (!words[index].IsHidden())
            {
                words[index].Hide();
                hidden++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }

    public int CountWordsHidden()
    {
        int count = 0;
        foreach (Word word in words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    public string GetDisplayText()
    {
        return $"{string.Join(" ", words.Select(word => word.IsHidden() ? "****" : word.Text))}";
    }

    public string ScriptureDisplay()
    {
        return $"{_reference}: {_text}";
    }


}