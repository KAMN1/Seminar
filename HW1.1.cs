using System;

namespace main




{

   class Program

   {
// ДЗ 1
   static void Main(string[] args){    

       

           Console.WriteLine("Введите первое число:");

           int a1 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Введите второе число:");

           int b2 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine(a1 > b2 ? a1 + " больше чем " + b2 : a1 + " меньше чем " + b2);

       

   
// ДЗ 2
       
       
       
        int max = 0;
        Console.WriteLine("Введите первое число:");

           int a = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Введите второе число:");

           int b = Convert.ToInt32(Console.ReadLine());
          
           Console.WriteLine("Введите третье число:");

           int c = Convert.ToInt32(Console.ReadLine());

           max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;

    Console.WriteLine(max);
       
       
   

   // ДЗ 3

    
        
      Console.WriteLine("Введите число : ");
      
      int a2 = Convert.ToInt32(Console.Read());
        
        if (a2 % 2 == 0) Console.WriteLine("Четное");
        
        else Console.WriteLine("Нечетное");
        
        Console.ReadKey();



        //дз 4

        Console.Write("Введите начало диавозона: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите конец диавозона: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");



   
   
   
   
   
   
   
   
   
   
   
   
   
   
   }

  
  
  
  
  
   }

        
    
    
    




}
   }}