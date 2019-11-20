using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Renomeeitor
{
    public class LeArquivoTxt
    {

        protected StreamReader objReader;
        protected string sLine = "";
        public List<String> arrText = new List<String>();

        public LeArquivoTxt(string txtPath)
        {
            objReader = new StreamReader(@txtPath);
        }

        public void LeArquivo()
        {
            while ((sLine = objReader.ReadLine()) != null)
            {
                sLine = sLine.Trim();
                sLine = sLine.Replace("\t", "");

                if (!String.IsNullOrEmpty(sLine))
                    arrText.Add(sLine);
            }

            objReader.Close();
        }
    }
}
