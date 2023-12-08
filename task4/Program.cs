// Дано натуральное число в диапазоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа.
// Старший разряд числа должен располагаться на 0-м индексе массива,
// младший – на последнем. Размер массива должен быть равен количеству цифр.

Console.WriteLine("Введите число от 1 до 100 000");
int number = Convert.ToInt32(Console.ReadLine());
int numeralCount = 0;
int num = number;
string output = "";
while (num>0)
{
    num = num/10;
    numeralCount++;
}
int[] array = new int[numeralCount];
Console.Write("[ ");
for (int i=(numeralCount-1); i>=0; i--)
    {
        array[i] = number % 10;
        number/=10;
        output = array[i] + " " + output;
    }
 Console.Write(output+"]");