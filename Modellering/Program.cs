using System;

namespace Modellering
{
  class Program
  {
    static void Main(string[] args)
    {
      Football theBall = new Football();
      Football theOtherBall = new Football();

      theBall.x = 40;
      theOtherBall.x = 60;

      System.Console.WriteLine(theBall.x);

      Console.ReadLine();
    }
  }
}
