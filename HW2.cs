using System;

namespace main

{
   class Program2
   {
   static void Main(string[] args){ 
// дз 1

Console.Clear();
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

// дз 2

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("Третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}

// дз 3

Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int day) {
  if (day == 6 || day == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(day);
   }
   }
}   