int[] numbers = Enumerable.Range(10, 99).ToArray();

int FindNumber1(int[] numbers)
{
    int result = 0;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
               
        if(numbers[i] % 10 == 1) 
        {
            count++;
            if (count>result) result = count;
        }
            
        
    }
    return result;
}

int FindNumber2(int[] numbers)
{
    int result = 0;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {                
        
        if(numbers[i] % 10 == 2) 
        {
            count++;
            if (count>result) result = count;
        }
       
    
    }
    return result;
}

int FindNumber3(int[] numbers)
{
    int result = 0;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {                
        
        if(numbers[i] % 10 == 3) 
        {
            count++;
            if (count>result) result = count;
        }
       
    
    }
    return result;
}
FindNumber1(numbers);
Console.WriteLine("Колличество чисел 1 равно {0}", FindNumber1(numbers));
FindNumber2(numbers);
Console.WriteLine("Колличество чисел 2 равно {0}", FindNumber2(numbers));
FindNumber3(numbers);
Console.WriteLine("Колличество чисел 3 равно {0}", FindNumber3(numbers));