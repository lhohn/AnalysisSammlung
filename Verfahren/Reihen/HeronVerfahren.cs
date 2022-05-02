using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verfahren.Reihen
{
    public class HeronVerfahren
    {
        public static double Heron(int x,int p,int a)
        {
            if(x == 0)
            {
                return 1.0;
            }

            return ((p-1.0)/p)*Heron(x-1,p,a)+a/(p*Math.Pow(Heron(x-1,p,a),p-1));
        }
    }
}
