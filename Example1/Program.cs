﻿using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Privetstvie pol'zovatelya
            //Console.Write("Введите ваше имя ");
            //string username = Console.ReadLine();
            //Console.Write("Привет, ");
            //Console.Write(username);

            //Slozhenie dvyx chisel
            //int numberA = 31;
            //int numberB = 5;
            //int result = numberA + numberB;
            //Console.WriteLine(result);


            //Delenie dvyx chisel s polycheniem tselogo chisla
            //int numberA = 12;
            //int numberB = 5;
            //Console.WriteLine(numberA / numberB);


            //Delenie dvyx chisel s polycheniem netselogo chisla
            //double numberA = 12;
            //double numberB = 5;
            //Console.WriteLine(numberA / numberB);

            //random chisla
            //int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
            //Console.WriteLine(numberA);
            //int numberB = new Random().Next(1, 10);
            //Console.WriteLine(numberB);
            //int result = numberA + numberB;
            //Console.WriteLine(result);


            //Raznoe privetstvie pol'zovateley s raznymi imenami
            //Console.Write("Введите ия пользователя: ");
            //string  username = Console.ReadLine();

            //if (username.ToLower() == "маша")
            //{
            //    Console.WriteLine("Ура, это же Маша!");
            //}
            //else
            //{ 
            //    Console.Write("Привет, ");
            //    Console.WriteLine(username);
            //}


            // Naxozhdenie maxx chisla
            //int a = 1;
            //int b = 2;
            //int c = 6;
            //int d = 8;
            //int e = 4;

            //int max = a;

            //if (a > max ) max = a;
            //if (b > max) max = b;
            //if (c > max) max = c;
            //if (d > max) max = d;
            //if (e > max) max = e;

            //Console.Write("max = ");
            //Console.WriteLine(max);



            //Zadacha c ispol'zovaniem operatora tsikla
            //Console.SetCursorPosition(10, 4);
            //Console.WriteLine("+");

            int xa = 40, ya = 1,
                xb = 1, yb = 30,
                xc = 80, yc = 30;

            Console.SetCursorPosition(xa, ya);
            Console.WriteLine("+");

            Console.SetCursorPosition(xb, yb);
            Console.WriteLine("+");

            Console.SetCursorPosition(xc, yc);
            Console.WriteLine("+");

            int x = xa, y = xb;


            int count = 0;

            while (count < 10000)
            { 
                int what = new Random().Next(0, 3); // [0; 3) 0, 1, 2
                if (what == 0)
                {
                    x = (x + xa) / 2;
                    y = (y + ya) / 2; 
                }
                if (what == 1)
                {
                    x = (x + xb) / 2;
                    y = (y + yb) / 2;
                }
                if (what == 2)
                {
                    x = (x + xc) / 2;
                    y = (y + yc) / 2;
                }
                Console.SetCursorPosition(x, y);
                Console.WriteLine("+");
                count++;
            }
            


        }
    }
}