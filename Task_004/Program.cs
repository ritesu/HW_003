Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()?? "0");
int c = 0;
while (a > 0)
{
    int b = a % 10;
    c = c + b;
    a = a / 10;
}
Console.WriteLine("Сумма цифр в числе равна {0}", c);