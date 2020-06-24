using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter temperture in celsius");
    var C = Console.ReadLine();
    Double C1 = Convert.ToDouble(C);
    Console.WriteLine((C1 * 9 / 5 ) + 32);
    var F = Console.ReadLine();
    Console.WriteLine("Farenheit equivalent is " + F);
    int F1 = Convert.ToInt32(F);
       if (F1 < 32)
     {
      Console.WriteLine("This temperature is below freezing of 32 degree Farenheit");
     }
        if (F1 > 212)
      {
      Console.WriteLine("This temperature is above boiling point of 212 degree Farenheit");
      }
  }
}