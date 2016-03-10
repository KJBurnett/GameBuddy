using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Buddy
{
    public class ImageHolderComp : IComparer<ImageHolder>
    {
        public int Compare(ImageHolder x, ImageHolder y)
        {
            return x.name.CompareTo(y.name);
        }
    }
}
