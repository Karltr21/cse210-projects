public class Save_Loader
{
    public void SaveEntries(string filename, List<JournalEntry> entries)
    {

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (JournalEntry entry in entries)
                {
                    outputFile.WriteLine($"{entry.prompt}|{entry.response}|{entry.entryDateTime}");
                }
            }
            Console.WriteLine($"Entries saved to file: {filename}");
        
    }

    public List<JournalEntry> LoadEntries(string filename)
    {
        List<JournalEntry> entries = new List<JournalEntry>();

            using (StreamReader inputFile = new StreamReader(filename))
            {
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                        string p = parts[0];
                        string r = parts[1];
                        DateTime e = DateTime.Parse(parts[2]);

                        entries.Add(new JournalEntry { prompt = p, response = r, entryDateTime = e});
                    
                }
            }
            Console.WriteLine($"Entries loaded from file: {filename}");

        return entries;
    }
}
