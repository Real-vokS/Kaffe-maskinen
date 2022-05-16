using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe_maskinen
{
    interface IFilter
    {

        void ContainIngrediens();

        void ReplaceFilter();

        public bool FilterIsUsed { get; }
        public bool FilterIsOn { get; }

    }
}
