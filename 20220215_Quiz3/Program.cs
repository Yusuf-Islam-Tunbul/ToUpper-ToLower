using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220215_Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            string input="";
            int change_mode = -1;
            int[,] values = new int[2, 3] { { 97,35,-32 }, { 65,35,+32 } };

            while (!valid)
            {
                Console.WriteLine("Harfleri büyütmek için 'büyüt', küçütlmek için 'küçült' yazınız.");

                input = Console.ReadLine().ToLower();

                if (input == "büyüt")
                {
                    valid = true;
                    change_mode = 0;
                    Console.WriteLine("\nBüyütmek istediğiniz metni giriniz.");
                }
                else if (input == "küçült")
                {
                    valid = true;
                    change_mode = 1;
                    Console.WriteLine("\nKüçültmek istediğiniz metni giriniz.");
                }
                else
                {
                    Console.WriteLine("\nYanlış bir giriş yaptınız.");
                }
            }

            Console.WriteLine(change_mode);
            string text = Console.ReadLine();
            string new_text = "";

            foreach(char letter in text)
            {
                if (Enumerable.Range(values[change_mode,0], values[change_mode, 1]).Contains((int)letter))
                {
                    new_text += (char)((int)letter + values[change_mode, 2]);
                }
                else
                {
                    new_text += letter;
                }
            }

            if (text == new_text)
            {
                Console.WriteLine("\nGirdiğiniz metinde bir değişiklik yapılmasına gerek kalmadı.");
            }
            else
            {
                Console.WriteLine("\nGirdiğiniz metnin değiştirilmiş hali:\n"+new_text);
            }

            Console.WriteLine("\nÇıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
