using System;

namespace CSharpFundamentals
{
  class Program
  {
    static void Main(string[] args)
    {
      int result;
      string input = Console.ReadLine();

      if (Int32.TryParse(input, out _))
      {
        result = Factorial(input);
      }
      else
      {
        Console.WriteLine("Can not convert input to int.");
      }

      Console.WriteLine("The factorial of ${0}! = ${1}!", input, result);
    }

    private int Factorial(int n)
    {
      if (n == 0)
      {
        return 1;
      }

      return Factorial(n - 1) * n;
    }
  }
}
