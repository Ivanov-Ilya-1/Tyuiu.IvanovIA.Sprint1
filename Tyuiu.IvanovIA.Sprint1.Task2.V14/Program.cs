using Tyuiu.IvanovIA.Sprint1.Task2.V14.Lib;
namespace Tyuiu.IvanovIA.Sprint1.Task2.V14
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #1 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine(" Тема : Арифметические операторы в C#                                     *");
            Console.WriteLine(" Задание #2                                                               *");
            Console.WriteLine(" Вариант #14                                                              *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Известна температура в градусах Кельвина. Перевести температуру          *");
            Console.WriteLine(" в градусы Цельсия.                                                       *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите температуру в градусах Кельвина: ");
            x = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Температура в градусах Цельсия: {ds.ConvertKelvinToCelsius(x)}");
            Console.ReadKey();

        }
    }
}