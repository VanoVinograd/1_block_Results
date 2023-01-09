// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длинна которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами. Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2" ]
// ["Russia", "Denmark", "Kazan"] -> []

string[] arr1 = new string[4] {"hello", "2", "world", ":-)"};
string[] arr2 = new string[arr1.Length];

LongerLessFour(arr1, arr2);
PrintArray(arr2);


void LongerLessFour(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
