// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

string[] inputArray = new string[7] { "Hello, world!", "123", "IT", ":)", "data science", "2+2", "time" };
string[] resultArray = new string[inputArray.Length];
resultArray = FilterArray(inputArray, resultArray);
PrintArray(resultArray);

string[] FilterArray(string[] input, string[] output)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            output[count] = input[i];
            count++;
        }
    }
    return output;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}