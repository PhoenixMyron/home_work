Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел
if ( n > m )
     Console.WriteLine($"{n} ");
else if ( n < m )
   Console.WriteLine($"{m} ");
