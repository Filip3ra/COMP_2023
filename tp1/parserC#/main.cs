// Meu primeiro programa em C#

using System;

namespace HelloWorld
{
  class Hello
  {
    static void Main(string[] args)
    {
      int i = 56;
      string _bananas = "bananas";

      /* concatena a string com o 56 *

      */
      Console.WriteLine("Hello World!" + i);

      /* Uma forma de ler um input */
      string name = Console.ReadLine();
      Console.WriteLine("Hello " + name);

      bool canVote = true;
      char grade = 'A';

    }
  }
}