using System;
using Classes;

namespace Classes
{
  class Program
  {
    static void Main(string[] args)
    {
      var a = Calculator.Add(1, 5);
      var b = Calculator.Subtract(a, 5);
      var c = Calculator.Multiply(b, 3);

      Console.WriteLine("The result is {0}", c);
    }
  }
}
