using System;

class Program
{
    static void Main()
    {
        // Входной массив строк
        string[] inputArray = { "Hello", "2", "world", ":-)" };

        // Создаем новый массив для хранения отфильтрованных строк
        string[] filteredArray = new string[inputArray.Length];
        int count = 0;

        // Фильтруем строки по длине
        foreach (var item in inputArray)
        {
            if (item.Length <= 3)
            {
                filteredArray[count] = item;
                count++;
            }
        }

        

        // Выводим результат
        
        Console.WriteLine("Результат:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(filteredArray[i]);
            jhg
        }
    }
}

