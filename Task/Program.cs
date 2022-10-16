
//Метод формирующий массив из строк, длина которых <= 3 символа
string[] GenResultArray(string[] inputArray)
{
    string[] ResultArray = new string[inputArray.Length];
    int count = 0;


    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {

            ResultArray[count] = inputArray[i];
            count++;


        }
    }
    return ResultArray;
}

// Вывод результата в консоль
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null)
        {
            Console.Write("[ " + $"{array[i]} " + " ] ");
        }
    }
    Console.WriteLine();
}

//string[] inputArray = new string[5] { "hello", "23455", "=)", "world", "Kazan" };

string[] inputArray = new string[5] { "1234", "1567", "-2", "computer science", "456" };
string[] ResultArray = GenResultArray(inputArray);

PrintArray(ResultArray);
