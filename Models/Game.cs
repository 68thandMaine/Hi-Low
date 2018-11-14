using System;

namespace HiLowGame {

  class Game
  {
    public int Number;

    public Game(int number)
    {
      Number = number;
    }

    Random rnd = new Random();
    public int Calculate(int start, int stop)
    {
      return (rnd.Next(start, stop));
    }

    // public int Lower(int stop)
    // {
    //   return (rnd.Next(0, stop));
    // }
  }
}
