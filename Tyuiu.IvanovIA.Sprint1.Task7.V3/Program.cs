using Tyuiu.IvanovIA.Sprint1.Task7.V3.Lib;
namespace Tyuiu.IvanovIA.Sprint1.Task7.V3
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #1 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine(" Тема : обавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine(" Задание #7                                                               *");
            Console.WriteLine(" Вариант #3                                                               *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Добавление к решению итоговых проектов по спринту                        *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("  z = (3 + e ^ (y - 1)) / (1 + x² * | y - tg(x) |)                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.WriteLine("Введите y :");
            y = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Ответ: {ds.Calculate(x,y)}");
            Console.ReadKey();

        }
    }
}