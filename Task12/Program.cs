Console.Clear();
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 % num2 == 0)
{
    Console.WriteLine($"{num1},{num2}->Кратно");
}
else
{
    Console.WriteLine($"{num1},{num2}->не кратно, остаток {num1 % num2}");
}