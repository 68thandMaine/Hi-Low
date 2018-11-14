using System;

namespace HiLowGame {

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Please enter a number between 1 & 100:");
      string strChoice = Console.ReadLine();
      int intChoice = int.Parse(strChoice);
      Game userChoice = new Game(intChoice);
      Console.WriteLine(userChoice.Number);

      int firstRandom = 0;
      firstRandom = userChoice.Calculate(1, 101);
      Console.WriteLine(firstRandom);
      ContinueHighLow(firstRandom, userChoice, 2 < 3);
    }

    static void ContinueHighLow(int randomNumber, Game choice, bool firstTime)
    {
      Console.WriteLine("Was your number higher, lower, or equal to the number? ['H' for higher, 'L' for lower, 'e' for equal to]");
      string stringAnswer = Console.ReadLine();
      if(firstTime){
        int setMargin1 = 0;
        int setMargin2 = 101;
        if (stringAnswer == "H" || stringAnswer == "h")
        {
          Console.WriteLine(randomNumber);
          setMargin1 = randomNumber;
          randomNumber = choice.Calculate(setMargin1, setMargin2);
          Console.WriteLine(randomNumber);
          ContinueHighLow(randomNumber, choice, False);
        }
        else if (stringAnswer == "L" || stringAnswer == "l")
        {
          Console.WriteLine(randomNumber);
          setMargin2 = randomNumber;
          randomNumber = choice.Calculate(setMargin1, setMargin2);
          Console.WriteLine(randomNumber);
          ContinueHighLow(randomNumber, choice, False);
        }
        else if (stringAnswer == "e" || stringAnswer == "E")
        {
          Console.WriteLine("I have guessed your number!" + randomNumber);
        }
      }
      else
      {
        if (stringAnswer == "H" || stringAnswer == "h")
        {
          Console.WriteLine(randomNumber);
          setMargin1 = randomNumber;
          randomNumber = choice.Calculate(setMargin1, setMargin2);
          Console.WriteLine(randomNumber);
          ContinueHighLow(randomNumber, choice, False);
        }
        else if (stringAnswer == "L" || stringAnswer == "l")
        {
          Console.WriteLine(randomNumber);
          setMargin2 = randomNumber;
          randomNumber = choice.Calculate(setMargin1, setMargin2);
          Console.WriteLine(randomNumber);
          ContinueHighLow(randomNumber, choice, False);
        }
        else if (stringAnswer == "e" || stringAnswer == "E")
        {
          Console.WriteLine("I have guessed your number!" + randomNumber);
        }
      }
    }

  }

}
