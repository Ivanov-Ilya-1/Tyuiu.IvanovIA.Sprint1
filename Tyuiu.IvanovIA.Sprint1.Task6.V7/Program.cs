using Tyuiu.IvanovIA.Sprint1.Task6.V7.Lib;
namespace Tyuiu.IvanovIA.Sprint1.Task6.V7
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #1 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine(" Тема : Работа со строками класса String                                  *");
            Console.WriteLine(" Задание #6                                                               *");
            Console.WriteLine(" Вариант #7                                                               *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #1                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу: пользователь вводит текст. Напечатать все слова,     *");
            Console.WriteLine(" удалив из них последнюю букву.                                           *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");


            
            Console.WriteLine("Введите текст : ");
            string text = Console.ReadLine();





            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Ответ: {ds.DeleteLastLetter(text)}");
            Console.ReadKey();

        }
    }
}