using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCode
{
    public class MorseDecoder
    {
        public IDictionary<string, string> MorseCodeDictionary = new Dictionary<string, string>() {
                { ".-", "A"},
                { "-...", "B"},
                { "-.-.", "C"},
                { "-..", "D"},
                { ".", "E"},
                { "..-.", "F"},
                { "--.", "G"},
                { "....", "H"},
                { "..", "I"},
                { ".---", "J"},
                { "-.-", "K"},
                { ".-..", "L"},
                { "--", "M"},
                { "-.", "N"},
                { "---", "O"},
                { ".--.", "P"},
                { "--.-", "Q"},
                { ".-.", "R"},
                { "...", "S"},
                { "-", "T"},
                { "..-", "U"},
                { "...-", "V"},
                { ".--", "W"},
                { "-..-", "X"},
                { "-.--", "Y"},
                { "--..", "Z"},
        };

        public string Decoder(string input)
        {
            string decodeString = "";
            string[] word = input.Split("   ");
            string[] letters;

            for (int i = 0; i < word.Length; i++)
            {
                letters = word[i].Split(" ");
                foreach (string s in letters)
                {
                    if (MorseCodeDictionary.ContainsKey(s))
                    {
                        decodeString += MorseCodeDictionary[s];
                    }
                    else
                    {
                        decodeString += "*";
                    }
                }
                if (i != word.Length - 1)
                {
                    decodeString += " ";
                }
            }
            return decodeString;
        }
    }
}
