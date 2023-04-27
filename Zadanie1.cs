// импортируем необходимые пространства имен
using System;
using System.Linq;

// создаем пространство имен "Library"
namespace Library
{
// создаем класс "Zadania"
public class Zadania
{
// создаем метод "ZadanieOne" для вывода чисел от 1 до N
public static void ZadanieOne()
{
Console.Write("Введите число N: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
Console.Write("Некорректный ввод. Введите положительное число N: ");
}
// изменяем формат вывода чисел, разделяя их символом новой строки вместо запятой
string result = string.Join(Environment.NewLine, Enumerable.Range(1, n));
Console.WriteLine(result);
}
    // создаем метод "ZadanieTwo" для вывода матрицы с центром в виде пробела
    public static void ZadanieTwo()
    {
        Console.Write("Введите нечетное число N: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n % 2 == 0 || n < 3)
        {
            Console.Write("Некорректный ввод. Введите нечетное число N, большее 3: ");
        }

        int center = n / 2;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row == center && col == center)
                {
                    // изменяем символ для центрального элемента матрицы
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    }

    // создаем точку входа в программу
    static void Main(string[] args)
    {
        // вызываем метод ZadanieTwo из класса Zadania
        Zadania.ZadanieTwo();

        // вызываем метод ZadanieOne из класса Zadania
        Zadania.ZadanieOne();

        // ждем, пока пользователь нажмет любую клавишу
        Console.ReadLine();
    }
}
}
