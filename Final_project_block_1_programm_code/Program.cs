// Задача: 
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
//-------------------------- Начало программы ----------------------------------
Console.Clear();
int n = GetNumberFromUser($"Please, enter the number of array elements: ", "Input error!"); // вызов метода запроса числа у пользователя
string[] array = GetArray(n);                                                               // вызов метода создания первоначального массива
Console.Write($"[{String.Join(",", array)}] -> ");                                          // вывод первоначального массива
FinalArray(array);                                                                          // вызов финального метода задачи
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// Метод запроса числа у пользователя с проверкой на ошибки ввода
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return Math.Abs(userNumber);
        Console.WriteLine(errorMessage);
    }
}
// Метод создания первоначального массива
string[] GetArray(int size)
{
    string[] result = new String[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Please, type any characters from the keyboard and press Enter: ");
        result[i] = $"'{Console.ReadLine()}'";
    }
    return result;
}
// Метод формирования из имеющегося массива строк массива из строк, длина которых меньше, либо равна 3 символа
void FinalArray(string[] Arr)
{
    int size = 0;
    int k = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].Length <= 5) size++;
    }
    string[] final = new String[size];
    for (int j = 0; j < Arr.Length; j++)
    {
        if (Arr[j].Length <= 5)
        {
            final[k] = Arr[j];
            k++;
        }
    }
    Console.Write($"[{String.Join(",", final)}]");
}

