using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filib
{
    static public class Filib
    {
        // Combines a multi-lined string to a single lined one. Having the space symbol represented by whatever you want.
        // Packs a string into one line.
        public static string PackLines(string str, char symbol) {
            string symbolP = symbol.ToString();
            string newString = str.Replace("\n", symbolP);
            return newString;
        }

        // Splits a packed string (from Pack lines). Splits it to allow a real space '\n' for every symbolic splitter one may have.
        // Unpacks a string into several lines.
        public static string UnPackLines(string str, char symbol) {
            string finalWord = "";
            string word = "";
            for (int i = 0; i < str.Length; i++) {
                if (str[i].Equals(symbol)) {
                    finalWord += word;
                    finalWord += "\n";
                    word = "";
                } else {
                    word += str[i];
                }
            }
            finalWord += word;
            return finalWord;
        }



    }
}
