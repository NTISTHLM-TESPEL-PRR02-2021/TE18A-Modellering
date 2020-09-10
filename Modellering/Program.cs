using System;
using System.Collections.Generic;

namespace Modellering
{
  class Program
  {
    static void Main(string[] args)
    {
      Football theBall = new Football();
      Football theOtherBall = new Football();

      Player p1 = new Player();
      Player p2 = new Player();

      p1.name = "Nånting";
      p2.name = "Nånting Annat";

      List<Player> teamBlue = new List<Player>();

      teamBlue.Add(new Player());



      theBall.x = 40;
      theOtherBall.x = 60;

      System.Console.WriteLine(theBall.x);

      Console.ReadLine();
    }
  }
}
