using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe_maskinen
{
    interface IFilter
    {


        public bool FilterIsUsed
        {
            get => filterIsUsed;
        }

        public bool FilterIsOn
        {
            get => filterIsOn;
        }

    }
}
