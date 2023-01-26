Console.WriteLine("Введите число для возвдения его в степень");
int a = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine()?? "0");
int[] numbers = new int[b];
int c = a;
int d = 0;
{
    Console.Write(b + " ");
}
Console.WriteLine();
Console.Write(a + " ");
for(int i = 1; i < numbers.Length; i++)
{
    d = c*a;
    c = d;
    Console.Write(c + " ");
}
Console.WriteLine();
Console.WriteLine("Результат равен {0}", c);