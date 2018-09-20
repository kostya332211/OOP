using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = "ss";  //неявно типизированная переменная

            sbyte num_0 = 127; // -128 to 127
            int num_1 = 100;
            short num_2 = 10;
            long num_3 = 10000000;
            byte num_4 = 255; // 0 to 255

            ushort num_5 = 99; //  0+
            uint num_6 = 999;
            ulong num_7 = 9999;

            char num_8 = 'A';
            bool num_9 = true;
            float num_10 = 1.23f;
            double num_11 = 1.234;
            decimal num_12 = 1000000;

            num_1 = num_0;    //неявное преобразование
            num_1 = num_2;
            num_2 = num_4;
            num_7 = num_6;
            num_5 = num_4;

            num_4 = (byte)num_0;
            num_3 = (long)num_12;
            num_1 = (int)num_11;
            num_10 = (float)num_11;
            num_8 = (char)num_1;

            object new_object = num_2;
            int num_22 = (int)(short)new_object;

            string str = null; //только для ссылочных типов
            int? number = null; //тип nullble от int  Nullable<int> number = null;

            //строки
            string first = "abcd";
            string second = "efgh";
            string third = "first word second word";
            if (first == second)
            {
                Console.WriteLine("first == second");
            }
            else
            {
                Console.WriteLine("first != second");
            }
            Console.WriteLine(System.String.Compare(first,second)); //СРАВНЕНИЕ СТРОК
            Console.WriteLine(System.String.Concat(second, first)); //сцепление +
            string new_abcde = System.String.Copy(first);
            Console.WriteLine(third.Substring(5));  //копирование строки от 5 символа
            string[] new_split = third.Split(' ');
            for (int i = 0; i < new_split.Length; i++)
            {
                Console.Write(new_split[i]+"+");
            }
            Console.WriteLine('\n'+first.Insert(3,second));
            Console.WriteLine(first.Remove(1));
            Console.WriteLine(System.String.Compare(second, str)); //cравнение с пустой строкой
            Console.WriteLine(System.String.Concat(second, str));

            StringBuilder new_str = new StringBuilder("ABCDEFGH", 20); //СТРОКА И МАКС РАЗМЕР
            new_str.Remove(2,4); //удаление от и до
            new_str.Append('1');
            new_str.Insert(0, '0');
            Console.WriteLine(new_str);

            //массивы
            int[,] mas_int = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
              for (int j = 0; j < 3; j++)
              Console.Write(mas_int[i, j]);
                Console.Write('\n');
            }

            string[] mas_str = { "a", "b", "c", "def123", "g" };
            foreach (string x in mas_str) Console.Write(x + ' ');
            Console.Write('\n'+"Position : ");
            int x_by_user = int.Parse(Console.ReadLine());
            Console.WriteLine("String : ");
            string string_by_user = Console.ReadLine();
            mas_str[x_by_user] = string_by_user;
            foreach (string x in mas_str) Console.Write(x + ' ');
            Console.WriteLine(" , length : " + mas_str.Length);

            int[][] mas_stup = { new int[2], new int[3], new int[4] };
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("first strring, element " + i);
                mas_stup[0][i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("first strring, element " + i);
                mas_stup[1][i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("first strring, element " + i);
                mas_stup[2][i] = int.Parse(Console.ReadLine());
            }

            foreach (int[] x in mas_stup)
            {
                foreach (int b in x)
                    Console.Write("\t" + b);
                Console.WriteLine();
            }
            var not_typ_str = "sss";
            var not_typ_mas = new[] { 1, 10, 100, 1000 };

            //КОРТЕЖИ

            ValueTuple<int , string, char, string, ulong> kort1 = (10,"tttt",'A',"TTTT",1000);
            ValueTuple<int, string, char, string, ulong> kort2 = (104, "teee", 'r', "231", 15);
            var tup = Tuple.Create(8, 9);
            (int, int) tt = ( 2, 3 );
            Console.WriteLine(kort1);
            Console.WriteLine(kort1.Item1 + " " + kort1.Item3 + " " + kort1.Item4);
            int first_element_of_cortege = kort1.Item1;  //по умолчаню ITEMn
            string second_element_of_cortege = kort1.Item2;
            char third_element_of_cortege = kort1.Item3;
            string fourth_element_of_cortege = kort1.Item4;
            ulong fifth_element_of_cortege = kort1.Item5;
            // if (kort1 == kort2) { } version 7.3 +

            int[] last_mass = { 1, 7, 4, 2, 8 };
            string last_string = "game over";
            int sykasykasykasykasykasyka_blet = 2;

        }
       


        
    }
}
