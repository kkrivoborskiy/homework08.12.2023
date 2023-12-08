// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

int[] array = new int[10];
int isFind = 0;
for (int i=0; i<array.Length; i++)
    {   
        array[i] = new Random().Next(1,21);
        if ( (array[i]%2) == 0)
            {
                isFind++;
            }
        Console.Write(array[i]+" ");
    }
Console.WriteLine("");
Console.Write(isFind);