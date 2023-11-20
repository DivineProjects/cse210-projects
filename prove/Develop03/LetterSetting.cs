public class LetterSetting
{
    public string Word { get; set; }
    public bool HasBeenGuessed { get; set; }

    public LetterSetting(string word, bool hasBeenGuessed)
    {
        this.Word = word;
        this.HasBeenGuessed = hasBeenGuessed;
    }
}