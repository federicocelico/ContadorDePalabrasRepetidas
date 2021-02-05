using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("Ingrese una palabra: ");
            word = Console.ReadLine();
            WordCount(word);
            Console.ReadKey();
            
        }

      

        public static void WordCount(string word)
        {
          
            string palabra;
            string[] words = word.Split(new char[] { ' ', ',', '.', ';' });
            var diccionario = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);


            for (int i = 0; i < words.Length; i++)
            {
                palabra = words[i].ToString();
                if (diccionario.ContainsKey(palabra))
                {
                    diccionario[palabra]++;
                }
                else
                {
                    diccionario.Add(palabra, 1);
                }
            }
            foreach (var entrada in diccionario)
            {
                Console.WriteLine($" {entrada.Key}  {entrada.Value} ");
            }

        }
    }
}
