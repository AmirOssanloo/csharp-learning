using System;

namespace CSharpFundamentals
{
  class Program
  {
    static void Main(string[] args)
    {
      int total = 0;
      string input;

      do
      {
        input = Console.ReadLine();

        if (Int32.TryParse(input, out _))
        {
          total += Convert.ToInt32(input);
        };
      } while (input != "ok");


      Console.WriteLine("The total is {0}!", total);
    }
  }
}
