using System;

namespace Task_1
{



    internal class Program
    {

        public static int CountWords(string Text)
        {
            int count_words = 1;

            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i].ToString() == " " || Text[i] == '\n' || Text[i] == '\0')
                {
                    count_words++;
                }
            }
            return count_words;
        }

        public static string[] StringDivision(string Text)
        {

            int count_words = CountWords(Text);

            string[] arrStr = new string[count_words];

            for (int i = 0; i < arrStr.Length; i++)
            {
                for (int j = 0; j < Text.Length; j++)
                {
                    if (Text[j].ToString() != " ")
                    { 
                        arrStr[i] = arrStr[i] + Text[j].ToString();
                    }

                    else if (Text[j].ToString() == " ")
                    {
                        i++;
                    }

                    else if (Text[j] == '\0')
                    {
                        break;
                    }
                }
                break;
            }
            return arrStr;
        }

        public static void PrintNewLine(string[] arrStr)
        {
            for(int i = 0; i < arrStr.Length; i++)
            {
                Console.WriteLine(arrStr[i]);
            }
        }

        static void Main(string[] args)
        {
            string Text = Console.ReadLine();

            StringDivision(Text);

            string[] arrStr = StringDivision(Text);
            
            PrintNewLine(arrStr);

        }
    }
}
