using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace Renomeeitor
{
    public static class StringExtensions
    {
        public static string ToUpper(string s)
        {
            return s.ToUpper();
        }

        public static string ToLower(string s)
        {
            return s.ToLower();
        }

        public static string UcFirst(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }

        public static string UcWords(string s)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
        }

        public static string CutBetween(string s, Container c)
        {
            return s.Substring(0, c.numb1 - 1) + s.Substring(c.numb2);
        }

        public static string AddAfter(string s, Container c)
        {
            return s.Substring(0, c.numb1) + c.txt1 + s.Substring(c.numb1);
        }

        public static string AddBefore(string s, Container c)
        {
            return c.txt1+s;
        }

        public static string AddAtEnd(string s, Container c)
        {
            List<string> trechos = new List<string>(s.Split('.'));
            string extensao = trechos.Last();
            trechos[trechos.Count - 1] = c.txt1;
            trechos.Add(extensao);
            return String.Join(".", trechos.ToArray()).Replace("." + c.txt1, c.txt1);
        }

        public static string RemoveSubString(string s, Container c)
        {
            List<string> trechos = new List<string>(s.Split('.'));
            string extensao = trechos.Last();
            trechos.RemoveAt(trechos.Count - 1);
            return String.Join(".", trechos.ToArray()).Replace(c.txt1, null) + "." + extensao;

            //return s.Replace(c.txt1, null);
        }
    }
}
