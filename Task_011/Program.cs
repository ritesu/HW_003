Console.WriteLine("Введите размер массива");
int a = int.Parse(Console.ReadLine()?? "");
int[] numbers = new int[a];
int length = numbers.Length;
int c = 0;
int d = 1;
for (int i = 0; i < numbers.Length; i++)
{
    int b = new Random().Next(1, 10);
    numbers[i] = b;
}
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();

for (int i = 0; i < numbers.Length/2; i++)
{
    c = numbers[i]*numbers[length - d];
    d = d + 1;
    Console.Write(c + " ");
}
