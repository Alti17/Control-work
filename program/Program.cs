string[] CreateStringArray(int size)
{
    string[] words=new string[size];
    for(int i=0; i<size; i++)
    {
        Console.Write($"Input {i+1} word: ");
        words[i] = Console.ReadLine();
    }
    return words;
}