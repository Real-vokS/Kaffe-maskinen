using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe_maskinen
{
    abstract class Powder
    {
        protected int gramsOfPowder;
        protected int gramsOfPowderToCup;


        public int GramsOfPowder
        {
            get => gramsOfPowder;
            set => gramsOfPowder = value;
        }

        public int GramsOfPowderToCup
        {
            get => gramsOfPowderToCup;
        }
    }
}
