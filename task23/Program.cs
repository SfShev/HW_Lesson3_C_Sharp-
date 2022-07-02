Console.WriteLine("Введите число");

int number1 = Convert.ToInt32(Console.ReadLine());
int i = 1;
int j = -1;

while (i <= number1)
{
    Console.Write($"{i * i * i}, ");
    i++;
}


while (j >= number1)
{
    Console.Write($"{j * j * j}, ");
    j -= 1;
}
Console.Write("\b \b");
Console.Write("\b \b");