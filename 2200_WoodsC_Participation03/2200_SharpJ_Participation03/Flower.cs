using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_SharpJ_Participation03
{
    public class Flower : Plant
    {
        public Flower(string env, string typ, string nm)
            : base(env, typ, nm)
        {            
        }

        // private

        //private int numberOfPetals;

        //public Flower()
        //{
        //    numberOfPetals = 0;
        //}

        //public Flower(string env, string typ, string nm, int nop)
        //    : base(env, typ, nm)
        //{
        //    numberOfPetals = nop;
        //}

        // sniff method

        public override string Sniff()
        {
            return "I like the smell of flowers";
        }

    }
}
