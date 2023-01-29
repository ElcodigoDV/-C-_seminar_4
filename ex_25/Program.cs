/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int NumToPow(int [] array)
{
    int lenght = array.Length;
    int a = array [0];
    int b = array [1];
    int result = a;
    int i = 1;
    while (i < b)
    {
        result = result *a;
        i ++;
    }
    return result;
}

int [] GetArray(string text)
{
    Console.WriteLine(text);
    int[] numbers = new int[2];
    string [] str = Console.ReadLine().Split(",");
    
    for (int i = 0; i < str.Length; i++)
    {
        numbers[i] = Int32.Parse(str[i]);
    }
    return numbers;
}

int [] arr = GetArray("Введите два числа через запятую a,b");
int result = NumToPow(arr);
string strArr = String.Join(", ", arr);
Console.WriteLine($"{strArr} -> {result}");

// Console.WriteLine(arr);