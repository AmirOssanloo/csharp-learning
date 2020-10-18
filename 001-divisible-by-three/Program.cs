using System;

namespace CSharpFundamentals
{
  class Program
  {
    static void Main(string[] args)
    {
      int current = 0;
      int found = 0;
      int target = 100;

      while (current <= target)
      {
        if (current % 3 == 0)
        {
          found++;
        }

        current++;
      }

      Console.WriteLine(found);
    }
  }
}
