using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.IvanovIA.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string[] words = value.Split(' ');
            string[] result = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                result[i] = words[i].Substring(0, words[i].Length - 1);
            }

            return string.Join(" ", result);
        }
    }
}
