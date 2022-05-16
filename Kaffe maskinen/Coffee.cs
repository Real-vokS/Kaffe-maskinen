using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe_maskinen
{
    internal class Coffee : Powder
    {


        public Coffee(int gramsOfPowder)
        {
            this.gramsOfPowder = gramsOfPowder;
            this.gramsOfPowderToCup = 5;

        }




    }
}
