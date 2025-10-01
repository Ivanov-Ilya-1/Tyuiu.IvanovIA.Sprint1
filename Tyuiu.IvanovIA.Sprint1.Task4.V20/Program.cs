using Tyuiu.IvanovIA.Sprint1.Task4.V20.Lib;
namespace Tyuiu.IvanovIA.Sprint1.Task4.V20
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #1 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine(" Тема : Class Math                                                        *");
            Console.WriteLine(" Задание #4                                                               *");
            Console.WriteLine(" Вариант #20                                                              *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine(" вычисляет результат по формуле и печатает его на экране.                 *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Формула : ");
            Console.WriteLine("1 + x / | x - Math.Sqrt(2+y)| ");
            Console.WriteLine(" *                                                                        *");
            double x;
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Ответ: {ds.Calculate(x, y)}");
            Console.ReadKey();

        }
    }
}