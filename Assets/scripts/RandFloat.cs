using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace Assets.scripts
{
    static class RandFloat
    {
        static int seed;

        public static int RandomInt(int min,int max)
        {
            seed = unchecked((int)DateTime.Now.Ticks)+seed;
            System.Random r = new System.Random(seed);
            int result = r.Next(min, max);
            seed += result;
            return result;
        }


    }
}
