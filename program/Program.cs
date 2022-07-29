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

void ShowArray(string[] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}