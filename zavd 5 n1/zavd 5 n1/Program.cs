using System;
namespace hm
{
    class task
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть речення: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[words.Length - i - 1] + " ");
            }
        }
    }
}

