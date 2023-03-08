Console.WriteLine("Введите первое число: ");
int namberA = Convert.ToInt32(value: Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int namberB = Convert.ToInt32(value: Console.ReadLine());
if(namberA > namberB)
{
    Console.Write("max = ");
    Console.WriteLine(namberA);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(namberB);   
}