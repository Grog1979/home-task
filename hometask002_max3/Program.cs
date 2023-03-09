//Максимальное из трех чисел
Console.WriteLine("Введите первое число: ");
int namberA = Convert.ToInt32(value: Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int namberB = Convert.ToInt32(value: Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int namberС = Convert.ToInt32(value: Console.ReadLine());
int max = namberA;
if(namberB > max) max = namberB;
if(namberС > max) max = namberС;

Console.Write("max = ");
Console.WriteLine(max);   

