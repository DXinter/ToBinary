using System;

namespace ToBinary
{
    /*
     *функция переводящая число в двоичный код
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            ulong input = Convert.ToUInt64(Console.ReadLine());
            string result = ToBinary(input);
            Console.WriteLine(result);
            Console.WriteLine("Обратный перевод: ");
            BackIn(result);

        }

        private static void BackIn(string result)
        {
            string r = Convert.ToInt64(result, 2).ToString();
            Console.WriteLine(r);
        }

        private static string ToBinary(ulong input)
        {
            char[] BinaryArray;                
            string Result = "";

            while (input > 0)
            {
                Result += input % 2;              
                input = input / 2;
            }

            BinaryArray = Result.ToCharArray();
            Array.Reverse(BinaryArray);
            Result = new string(BinaryArray);
            return Result;
        }
    }
}
