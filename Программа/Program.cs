//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] Array1 = new string[4] {"hello", "2", "world", ":)"};
string[] Array2 = new string[Array1.Length];

void Array(string[] Array1, string[] Array2)
{
    int count = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
    if(Array1[i].Length <= 3)
        {
        Array2[count] = Array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
    
}
Array(Array1, Array2);
PrintArray(Array1);
Console.WriteLine($"[{String.Join(" ", Array2)}]");


