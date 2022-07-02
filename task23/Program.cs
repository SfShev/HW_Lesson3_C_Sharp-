Console.WriteLine("Если хотите узнать кубы чисел от 1 до N  или от N до -1");
Console.WriteLine("Введите число N:");

int number1 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number1; i++)
{
    Console.Write($"{i * i * i}, ");

}


for (int j = -1; j >= number1; j -=1 )
{
    Console.Write($"{j * j * j}, ");
    
}
Console.Write("\b \b");
Console.Write("\b \b");