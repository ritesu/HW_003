Console.WriteLine("Введите число для возвдения его в степень");
int a = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine()?? "0");
int[] numbers = new int[b];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = b;
}
int c = a;

Console.Write(a + " ");

for(int i = 1; i < numbers.Length; i++)
{
    c = c*a;
    Console.Write(c + " ");
}
Console.WriteLine();
Console.WriteLine("Результат равен {0}", c);