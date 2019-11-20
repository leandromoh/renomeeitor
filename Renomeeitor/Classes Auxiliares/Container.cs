using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renomeeitor
{
    public class Container
    {
        public string txt1 = null;
        public string txt2 = null;
        public int numb1 = -1;
        public int numb2 = -1;

        public Container(string Trecho)
        {
            this.txt1 = Trecho;
        }

        public Container(string Trecho, string Trecho2)
        {
            this.txt1 = Trecho;
            this.txt2 = Trecho2;
        }

        public Container(string Trecho, int Numb1)
        {
            this.txt1 = Trecho;
            this.numb1 = Numb1;
        }

        public Container(int Numb1, int Numb2)
        {
            this.numb1 = Numb1;
            this.numb2 = Numb2;
        }
    }
}
