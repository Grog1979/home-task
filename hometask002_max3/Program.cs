//Максимальное из трех чисел
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(value: Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(value: Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberС = Convert.ToInt32(value: Console.ReadLine());
int max = numberA;
if(numberB > max) max = numberB;
if(numberС > max) max = numberС;

Console.Write("max = ");
Console.WriteLine(max);   

