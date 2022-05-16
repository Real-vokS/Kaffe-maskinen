using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe_maskinen
{
    internal class Brewer
    {
        public ILiquidContainer LiquidContainer { get; set; }
        public IFilter Filter { get; set; }

        public Brewer(ILiquidContainer liquidContainer, i)
        {
            this.LiquidContainer = liquidContainer;
        }



        public void AddPowder(Powder powder)
        {

        }


    }
}
