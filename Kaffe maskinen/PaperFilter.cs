using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe_maskinen
{
    internal class PaperFilter : IFilter
    {

        bool filterIsUsed = false;
        bool filterIsOn = false;

        public void ContainIngrediens()
        {

        }

        public void ReplaceFilter()
        {

        }

        public bool FilterIsOn
        {
            get => filterIsOn;
        }

        public bool FilterIsUsed
        {
            get => filterIsUsed;
        }

    }
}
