Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 3-ое число: ");
int l = Convert.ToInt32(Console.ReadLine()); // ввод чисел
int max = 0;
if ( n > m )
{
     max = n;
     if ( n > l )
     {
        max = n;
        Console.WriteLine($"{n} ");
     }
     else if ( n < l )
     {
        Console.WriteLine($"{l} ");
     }

}
else if ( n < m )
   {
    max = m;
    if ( m > l )
    {
        max = m;
        Console.WriteLine($"{m} ");
    }
    else if ( m < l )
    {
        max = l;
        Console.WriteLine($"{l} ");
    }
   }

