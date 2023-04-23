Console.Clear();


Console.Write("Задайте длину массива: ");
bool flag = int.TryParse(Console.ReadLine()!, out int N);

string[] Arr = new string[N];
string[] ArrFinal = new string[Arr.Length];
FillArray(Arr);
PrintArray(Arr);
Console.WriteLine();
CreatArray(Arr, ArrFinal);




string[] FillArray(string[] array)
{
    for (int i = 0; i < N; i++)
    {
       array[i] = Convert.ToString(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"a[{i}] = {arr[i]}");
}

void CreatArray(string[] arr, string[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            array[i] = arr[i];
            Console.WriteLine($"{array[i]}");
        }
    }
    
}