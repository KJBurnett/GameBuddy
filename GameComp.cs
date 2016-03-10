using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Buddy
{
    public class GameComp : IComparer<Game>
    {
        public int Compare(Game x, Game y)
        {
            return x.name.CompareTo(y.name);
        }
    }
}
