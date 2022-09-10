Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i < number+1; i++)
{
    Console.WriteLine(i*i*i);
}