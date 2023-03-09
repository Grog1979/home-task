// positive and negative numbers
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(value: Console.ReadLine());
for(int i = 2; i <= n; i = i + 2)
    Console.Write($"{i} ");