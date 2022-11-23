Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел

double z = n % 2;
if ( z == 0 )
    Console.Write($"{true} ");
else 
    Console.Write($"{false} ");
