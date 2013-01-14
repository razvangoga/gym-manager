using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyControls.Logic
{
    public class Strings
    {
        private static Hashtable charsToBeEscaped = null;

        static Strings()
        {
            GenerateEscapeCharsHashTable();
        }

        private static void GenerateEscapeCharsHashTable()
        {
            charsToBeEscaped = new Hashtable();

            charsToBeEscaped.Add(34, "\"");
            charsToBeEscaped.Add(35, "#");
            charsToBeEscaped.Add(38, "&");
            charsToBeEscaped.Add(91, "[");
            charsToBeEscaped.Add(92, "\\");
            charsToBeEscaped.Add(93, "]");
            charsToBeEscaped.Add(94, "^");
            charsToBeEscaped.Add(124, "|");
            charsToBeEscaped.Add(126, "~");
        }

        public static string EscapeSpecialChars(string sOriginalFilterString)
        {
            string sEscapedFilterString = string.Empty;

            for (int i = 0; i < sOriginalFilterString.Length; i++)
            {
                if (charsToBeEscaped.ContainsKey(Convert.ToInt32(sOriginalFilterString[i])))
                {
                    sEscapedFilterString += string.Format("[{0}]",
                        sOriginalFilterString[i]);
                }
                else
                {
                    sEscapedFilterString += sOriginalFilterString[i];
                }
            }
            return sEscapedFilterString;
        }
    }

}
