using System;
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {

        _text = text;
        _isHidden = false;
    }

    public string Text { 
        get { return _text; } }

    public bool IsHidden() 
    { 
        return _isHidden; 
        }

    public void Hide() 
    { 
        _isHidden = true; 
    }

    public void Show() 
    { 
        _isHidden = false; 
    }
}