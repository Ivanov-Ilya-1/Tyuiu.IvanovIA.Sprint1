using Tyuiu.IvanovIA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.IvanovIA.Sprint1.Task5.V5
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
            Console.WriteLine(" Задание #5                                                               *");
            Console.WriteLine(" Вариант #5                                                              *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу, которая решает следующую задачу:                     *");
            Console.WriteLine(" Присвоить целой переменной d первую цифру из дробной части               *");
            Console.WriteLine(" положительного вещественного числа x (так, если x=32.597, то d=5).       *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

                                                     
            double x;
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());





            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Ответ: {ds.Calculate(x)}");
            Console.ReadKey();

        }
    }
}