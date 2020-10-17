using System;

namespace TypeCasting
{
  class Program
  {
    static void Main(string[] args)
    {
      // This will compile because there we can implicitly (without dataloss) covert a 'byte' to an 'int'
      byte a1 = 1;
      int b1 = a1;

      // -------
      // This will not compile because we cannot implicitly (without dataloss) convert type 'int' to 'byte'
      //   int a2 = 1;
      //   byte b2 = a2;

      // ------
      // This will explicitly convert type 'int' to 'byte' and will output 1 since the number wraps
      int a3 = 257;
      byte b3 = (byte)a3;
      System.Console.WriteLine(b3);

      // -------
      // Will convert the type 'string' to 'int' without a problem
      string a4 = "1234";
      int b4 = Convert.ToInt32(a4);
      System.Console.WriteLine(a4);

      // -------
      // Will not compile because the compiler will throw OverflowException.
      string a5 = "1234";
      byte b5 = Convert.ToByte(a5);
      System.Console.WriteLine(a5);
    }
  }
}
