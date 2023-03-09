//Максимальное из двух чисел
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(value: Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(value: Console.ReadLine());
if(numberA > numberB)
{
    Console.Write("max = ");
    Console.WriteLine(numberA);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(numberB);   
}