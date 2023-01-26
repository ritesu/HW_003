Console.WriteLine("Введите колличество чисел для возведения в куб");
int a = int.Parse(Console.ReadLine()?? "");
int[] numbers = new int[a];
int c = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int b = new Random().Next(0, 9);
    numbers[i] = b;
}
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine("Кубы четных чисел");

for (int i = 0; i < numbers.Length; i++)
{
    c = numbers[i]*numbers[i]*numbers[i];
    if (c % 2 == 0 && c > 0)
    {
        Console.Write(c + " ");
    }
}
