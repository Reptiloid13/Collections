using System.Diagnostics;

namespace Collections;

public class Program
{
    public static LinkedList<string> LinkedList = new LinkedList<string>();
    static void Main(string[] args)
    {
        //Задание 13.6.1
        //  Наша задача — сравнить производительность
        //  вставки в List<T> и LinkedList<T>.
        //  Для этого используйте уже знакомый вам StopWatch.
        //На примере этого текста, выясните,
        //какие будут различия между этими коллекциями.



        // Чтение текста из файла
        var path = @"D:\Repos\Collection\Collections\Collections\input.txt";
        var fileText = File.ReadAllText(path);

        // 
        char[] seperators = new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?', '(', ')', '[', ']', '{', '}' };
        string[] words = fileText.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine($"Words count - {words.Length}");

        GetCompareListLinked(words);
    }

    public static List<string> GetWordList(string[] words)
    {
        var list = new List<string>(words);
        return list;
    }

    public static LinkedList<string> GetWordLinkedList(string[] words)
    {
        var linkedList = new LinkedList<string>(words);

        return linkedList;
    }
    public static void GetCompareListLinked(string[] words)
    {

        //Test Link
        var listStopWatch = Stopwatch.StartNew();
        var list = GetWordList(words);
        listStopWatch.Stop();
        Console.WriteLine($"List creation time is  - {listStopWatch.ElapsedMilliseconds} ms");


        //TestLinkedList
        var linkedListStopWatch = Stopwatch.StartNew();
        var linkedList = GetWordLinkedList(words);
        linkedListStopWatch.Stop();
        Console.WriteLine($"LinkedList creation time is - {linkedListStopWatch.ElapsedMilliseconds} ms ");



    }

}

