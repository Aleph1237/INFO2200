using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_SharpJ_Participation03
{
    public class Shrub : Plant
    {
        public Shrub(string env, string typ, string nm)
            : base(env, typ, nm)
        {
        }

        public override string Sniff()
        {
            return "I like the smell of shrubs";
        }
    }
}
