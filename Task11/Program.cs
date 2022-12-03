Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Число {num}");
int num1 = num % 10;
int num2 = num / 100;
Console.WriteLine($"{num2}{num1}");