using Tyuiu.IvanovIA.Sprint1.Task3.V12.Lib;
namespace Tyuiu.IvanovIA.Sprint1.Task3.V12
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #1 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine(" Тема : Операторы составного присваивания                                 *");
            Console.WriteLine(" Задание #3                                                               *");
            Console.WriteLine(" Вариант #12                                                              *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу для вычисления площади прямоугольного треугольника    *");
            Console.WriteLine(" по длинам двух катетов. Ответ округлите до 3 знаков после запятой.       *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double x;
            Console.WriteLine("Введите длинну первого катета:");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.WriteLine("Введите длину второго катета:");
            y = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Площадь треугольника равна: {ds.TriangleArea(x,y)}");
            Console.ReadKey();

        }
    }
}