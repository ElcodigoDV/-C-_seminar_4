/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void PrintArr(int [] array)
{
    int k = array.Length;
    for (int j = 0; j < k; j++)
    {
        if (j == k-1)
        {
            Console.Write($"{array[j]}");
        }
        else
        {
            Console.Write($"{array[j]},");
        }
    }
}

void NewArray(int [] array)
{
    // int [] arr = new int [8];
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

//делаем массив из 8-ми эл-ов
int [] arr = new int [8];
NewArray(arr);

//Выводим ана печать каждый элемент
PrintArr(arr);




