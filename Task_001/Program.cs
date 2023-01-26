Console.WriteLine("Введите размер массива");
int a = int.Parse(Console.ReadLine()?? "");
int[] numbers = new int[a];
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
Console.WriteLine("Кубы всех чисел равны");
for (int i = 0; i < numbers.Length; i++)
{
    int c = numbers[i]*numbers[i]*numbers[i];
    Console.Write(c + " ");
}
