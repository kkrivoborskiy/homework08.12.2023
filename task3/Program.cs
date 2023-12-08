// Задайте массив из вещественных чисел 
// с ненулевой дробной частью.Найдите разницу между 
// максимальным и минимальным элементов массива.

double[] array = new double[5];
array[0] = new Random().NextDouble()*99+1; //число между 1 и 100. (max-min)+min
Console.Write(array[0]+" ");
double min=array[0], max=array[0];
for (int i=1; i<array.Length; i++)
    {   
        array[i] = new Random().NextDouble()*99+1;
        Console.Write(array[i]+" ");
        if (array[i]<min)
            min = array[i];
        else if (array[i]>max)
            max = array[i];
    }
Console.WriteLine("");
Console.WriteLine(max-min);