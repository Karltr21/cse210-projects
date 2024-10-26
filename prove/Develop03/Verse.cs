using System;
using System.Collections.Generic;

class Verse
{
    private List<string> Verse_Words = new List<string>
    {
        "So", "do", "not", "fear", "for", "I", "am", "with", "you",
        "do", "not", "be", "dismayed", "for", "I", "am", "your", "God",
        "I", "will", "strengthen", "you", "and", "help", "you",
        "I", "will", "uphold", "you", "with", "my", "righteous", "right", "hand."
    };
    
    private HashSet<int> hiddenIndexes = new HashSet<int>(); // Track hidden word indexes

    public void HideRandomWords(int count = 3)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(count, Verse_Words.Count - hiddenIndexes.Count);

        while (hiddenIndexes.Count < Verse_Words.Count && wordsToHide > 0)
        {
            int randomIndex = random.Next(Verse_Words.Count);

            // Only hide if not already hidden
            if (!hiddenIndexes.Contains(randomIndex))
            {
                hiddenIndexes.Add(randomIndex);
                wordsToHide--;
            }
        }
    }

    public List<string> GetVerseWithHiddenWords()
    {
        List<string> verseDisplay = new List<string>();

        for (int i = 0; i < Verse_Words.Count; i++)
        {
            // Replace hidden words with underscores
            if (hiddenIndexes.Contains(i))
            {
                verseDisplay.Add(new string('_', Verse_Words[i].Length));
            }
            else
            {
                verseDisplay.Add(Verse_Words[i]);
            }
        }

        return verseDisplay;
    }
}
