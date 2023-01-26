Console.WriteLine("Введите размер массива");
int a = int.Parse(Console.ReadLine()?? "");
int[] numbers = new int[a];
int max = 0;
int min = numbers.Length;
for (int i = 0; i < numbers.Length; i++)
{
    int b = new Random().Next(-10, 10);
    numbers[i] = b;
}
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= max)
    {
        max = numbers[i];
    }
}
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] <= min)
    {
        min = numbers[i];
    }
}
Console.Write(max + " ");
Console.Write(min);