// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string[] FillArray(int length)
{
    string[] array = new string[length];
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Введите {i+1}й элемент: ");
            array[i] = Console.ReadLine()??"0";
        }
        Console.WriteLine();
    }
    return array;
}
int FindNewArrayLength(string[] someArray, int number)
{
     int count = 0;
     for (int i = 0; i < someArray.Length; i++)
     {
        if (someArray[i].Length <= number)
           count++;
     }
     return count;
}
string[] CreateNewArray(string[] someArray, int length, int number)
{
    string[] newArray = new string[length];
    int j = 0;
    for (int i = 0; i < someArray.Length; i++)
    { 
        if (someArray[i].Length <= number)
        {
            newArray[j] = someArray[i];
            j++;
        }
    }
    return newArray;
}
string PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        return "[]";
    }
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            result += $"\"{array[i]}\"";
        else 
            result += $"\"{array[i]}\", ";
    }
    result += "]";
    return result;
}
Console.Write("Введите длину первоначального массива строк: ");
int arrayLength = int.Parse(Console.ReadLine()??"0");
string[] stringArray = FillArray(arrayLength);
int newArrayLength = FindNewArrayLength(stringArray, 3);
string[] newArray = CreateNewArray(stringArray, newArrayLength, 3);
Console.Write($"{PrintArray(stringArray)} -> {PrintArray(newArray)}");

