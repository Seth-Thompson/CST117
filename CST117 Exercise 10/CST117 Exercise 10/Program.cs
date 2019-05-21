using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CST117_Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Create a StreamReader Object "textFile" that reads from the text file "text.txt"
                StreamReader textFile = new StreamReader("text.txt");

                //Reads through the line splitting the input into smaller strings stored within a String array.
                String[] stringArray = textFile.ReadToEnd().Split();
                int numTorE = 0;

                //Each subString within the stringArray is cycled through.
                foreach (String subString in stringArray)
                {
                    //The end of each subString is checked to see if the final char is a punctuation.
                    if (char.IsPunctuation(subString, subString.Length - 1))
                    {
                        //If so then string is trimmed.
                        String noPunString = subString.Remove(subString.Length - 1);

                        //the loop is continued until all punctuation is removed from the string.
                        while (char.IsPunctuation(noPunString, noPunString.Length - 1))
                        {
                            noPunString = noPunString.Remove(noPunString.Length - 1);
                        }

                        //this new string is then checked and the count is increased if it ends with "t" or "e" in either case.
                        if (noPunString.EndsWith("t") || noPunString.EndsWith("e") ||
                            noPunString.EndsWith("T") || noPunString.EndsWith("E"))
                        {
                            numTorE++;
                        }
                    }

                    //a string with no punctuation is checked and the count is increased if it ends with "t" or "e" in either case.
                    if (subString.EndsWith("t") || subString.EndsWith("e") ||
                        subString.EndsWith("T") || subString.EndsWith("E"))
                    {
                        numTorE++;
                    }
                }

                Console.WriteLine("There are " + numTorE + " words that end in t or e");
                textFile.Close();
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
