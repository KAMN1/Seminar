﻿using System;

namespace main




{

   class Program

   {

       static void Main(string[] args)

       {

           Console.WriteLine("Введите первое число:");

           int a = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Введите второе число:");

           int b = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine(a > b ? a + " больше чем " + b : a + " меньше чем " + b);

       }

   }
}
