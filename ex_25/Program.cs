/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* int NumToPow(array)
{
    int lenght = array.Lenght
    int a = array [0];
    int b = array [1];
    int result = a;
    while (int i = 1, i < b)
    {
        result = result *a;
        i ++
    }
    return result;
}
 */
int GetArray(string text)
{
    Console.WriteLine(text);
    int[] numbers = new int[2];
    string[] str = Console.ReadLine().Split(",");
    
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Int32.Parse(str[i]);
    }
    return numbers;
}

string arr = GetArray("Введите два числа через запятую a,b");
int result = NumToPow(arr);
Console.WriteLine(result);

// Console.WriteLine(arr);