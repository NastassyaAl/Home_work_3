Console.Clear();
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
string Num = Convert.ToString(number);
if (number.Length != 5)
{
    Console.WriteLine("Неправильное количество символов");
}
else
{
    if (Num[0] == Num[4] || Num[1] == Num[3])
    {
        Console.WriteLine("Это число является полиндромом");
    }
    else
    {
    Console.WriteLine("Это не полиндром");
    }
}
