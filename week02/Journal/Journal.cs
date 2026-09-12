public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();
        foreach (Entry entry in _entries)
        {
            lines.Add($"{entry._dateText}|{entry._promptText}|{entry._entryText}");
        }
        System.IO.File.WriteAllLines(filename, lines);
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._dateText = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }
}