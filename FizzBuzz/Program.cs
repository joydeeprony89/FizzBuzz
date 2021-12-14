using System;

namespace FizzBuzz
{
  class Program
  {
    private readonly string FIZZ = "Fizz";
    private readonly string BUZZ = "Buzz";
    private readonly string FIZZBUZZ = "FizzBuzz";
    static void Main(string[] args)
    {
      Program p = new Program();
      p.FizzBuzz(3, 7, 15);
    }

    void FizzBuzz(int x, int y, int range)
    {
      int xMultiple = 1, yMultiple = 1, fizz = 1, buzz = 1;
      int noOfLooping = 0;
      while (fizz <= range && buzz <= range)
      {
        fizz = x * xMultiple;
        buzz = y * yMultiple;
        if (fizz < buzz)
        {
          Console.WriteLine(fizz + FIZZ);
          xMultiple++;
        }
        else if (fizz == buzz)
        {
          Console.WriteLine(fizz + FIZZBUZZ);
          xMultiple++; yMultiple++;
        }
        else
        {
          Console.WriteLine(buzz + BUZZ);
          yMultiple++;
        }
        noOfLooping++;
      }

      Console.WriteLine($"no of iterations = {noOfLooping}");
    }
  }
}
