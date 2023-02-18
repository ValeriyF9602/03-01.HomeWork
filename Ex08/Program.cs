// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


int i;
string result = "Все чётные числа от 1 до N: ";

Console.Write("Введиче число N: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1) // как я понял по условию задачи, чётные числа начинаем отсчитывать от +1 и поэтому если N положитьельный, то результат начинается от 2, а если отрицательный — от 0.
{
    for (i = 0; i >= num; i = i - 2)
    {
        if (i % 2 == 0)
        {
            if (i > num && i != num + 1)
            {
                result = result + i + ", ";
            }
            else
            {
                result = result + i + ".";
            }
        }
    }
}
else
{
    for (i = 2; i <= num; i = i + 2)
    {
        if (i % 2 == 0)
        {
            if (i < num && i != num - 1)
            {
                result = result + i + ", ";
            }
            else
            {
                result = result + i + ".";
            }
        }
    }
}

if (num == 1) result = "Чётные числа от 1 до N не найдены";
Console.WriteLine(result);