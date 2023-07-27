// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        string path = "C:\\Users\\PC-89091\\Documents\\OneDrive_2023-07-25\\Table Fields";
        string resultPath = "C:\\Users\\PC-89091\\Documents\\OneDrive_2023-07-25\\Table Fields por comas";
        var files = Directory.GetFiles(path, "*.txt");
        string[] text;
        String phrase;
        String eachFileName;
        String[] newText;
        foreach (var item in files)
        {
            text = File.ReadAllLines(item);
            eachFileName = Path.GetFileName(item);
            phrase = text[0];
            newText = phrase.Split('\t');
            phrase = String.Join(",", newText)+Environment.NewLine;
            File.AppendAllText(resultPath+$"\\{eachFileName}", phrase);
        }
        Console.WriteLine("Done");
    }
}
