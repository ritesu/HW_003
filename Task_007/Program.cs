int[] numbers = new int [8];
for (int i = 0; i < numbers.Length; i++)
{
    int num = new Random().Next(0,2);
    numbers[i] = num;
}
foreach (int i in numbers)
{
    Console.Write(i + " ");
}