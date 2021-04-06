using System;
using System.Collections.Generic;
using System.Linq;

namespace MorseCode
{
      class Program
    {
        static void Main(string[] args)
        {
        MorseDecoder morse = new MorseDecoder();
        String input = Console.ReadLine();
        Console.WriteLine(morse.Decoder(input));
        Console.ReadKey();
        }
    }
}
    


    
