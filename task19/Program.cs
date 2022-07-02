Console.WriteLine("Если хотите узнать является ли пятизначное число палиндромом");
Console.Write("Введите пятизначное число: ");

int Number = Convert.ToInt32(Console.ReadLine());

string palindrome = Number.ToString();

if (palindrome[0] == palindrome[4] && palindrome[1] == palindrome[3])
{
    Console.Write($"Число {Number} является палиндромом ");
}
if (palindrome[0] != palindrome[4])
{

    Console.Write($"Число {Number} не является палиндромом ");
}
