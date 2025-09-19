using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Фильтрация массива строк ===");
        Console.WriteLine("Введите строки через запятую:");
        
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');
        
        // Убираем пробелы
        for (int i = 0; i < inputArray.Length; i++)
        {
            inputArray[i] = inputArray[i].Trim();
        }
        
        // Фильтруем массив
        string[] resultArray = FilterStrings(inputArray);
        
        // Выводим результат
        Console.WriteLine("\nРезультат:");
        PrintArray(resultArray);
    }
    
    static string[] FilterStrings(string[] array)
    {
        // Подсчитываем количество подходящих строк
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
        
        // Создаём новый массив
        string[] result = new string[count];
        int index = 0;
        
        // Заполняем новый массив
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }
        
        return result;
    }
    
    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"");
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}