namespace read_text;

class Program
{
    static Array ReadWord()
    {
        string path = @"C:\\Users\\wzsgp\\RiderProjects\\ConsoleApplication1\\read text\\words.txt";
        string rawWords = File.ReadAllText(path);
        string currentWord = "";
        List<string> wordsList = new List<string>();
        foreach (char i in rawWords)
        {
            if (i == " "[0])
            {
                wordsList.Add(currentWord);
                currentWord = "";
            }
            else
            {
                currentWord += i;
            }
        }
        wordsList.Add(currentWord);
        string[] words = wordsList.ToArray();
        return words;
    }
    
    static Array ReadWordByLine()
    {
        string path = @"C:\\Users\\wzsgp\\RiderProjects\\ConsoleApplication1\\read text\\words.txt";
        List<string> wordsList = new List<string>();
        foreach (var i in File.ReadLines(path))
        {
            wordsList.Add(i);
        }
        string[] words = wordsList.ToArray();
        return words;
    }
    
    static void Main(string[] args)
    {
        foreach(var i in ReadWordByLine())
        {
            Console.WriteLine(i);
        }
    }
}
