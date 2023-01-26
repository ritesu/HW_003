Console.WriteLine("Введите до какого числа выполнить произведение");
int[] numbers = Enumerable.Range(1, 99).ToArray();
int a = int.Parse(Console.ReadLine()?? "");
Array.Resize(ref numbers, a);
int b = 1;
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    b = b*numbers[i];
    Console.Write(b + " ");
}
Console.WriteLine();
Console.Write("Произведение чисел равна {0}", b);