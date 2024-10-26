using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;


class Scripture_Citation
{
    private string _word;
    private bool  _revealed = false;

    public Scripture_Citation(string word, bool hidden)
        {
            _word = word;
            _revealed = hidden;
        }

    public string GetWord ()
    {
        return _word;
    }
    public void SetWord (string word)
    {
        _word = word;
    }

    public bool Hidden()
    {
        return _revealed;
    }
    public void SetHidden(bool i)
    {
        _revealed = i;
    }
    public string HideWord ()
    {
        
        if (!_revealed)
        {
            return _word;
        }
        else
        {
            string Hiddenword = "";
            foreach (char letters in _word)
            {
                Hiddenword += "_";

            }
            _revealed = true;
            return Hiddenword;

        }
    }
    
}