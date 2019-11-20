using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Renomeeitor.Classes_Auxiliares
{
    class GravaArquivoTxt
    {
        public string strPathFile;
        FileStream fs;

        public GravaArquivoTxt(string s)
        {
            this.strPathFile = s;
            this.fs = File.Create(@s);
            this.fs.Close();
        }

        public void Gravar(string line)
        {
            StreamWriter writer = new StreamWriter(@strPathFile, true);
            using (writer)
            {
                writer.WriteLine(line);
            }
        }
    }
}