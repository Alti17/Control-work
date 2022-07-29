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

string[] ExclusionOfElements(string[] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            count++;
        }
    }
    string[] newarray=new string[count];
    int k=0;
    for (int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            newarray[k] = array[i];
            k++;
        }
    }
    return newarray;
}

Console.Write("Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array=CreateStringArray(size);
ShowArray(array);
string[] newarray = ExclusionOfElements(array);
ShowArray(newarray);