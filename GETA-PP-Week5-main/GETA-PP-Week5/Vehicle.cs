using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GETA_PP_Week5
{
    public abstract class Vehicle
    {
        public string RegNo;
        public int Effect;

        protected Vehicle(string RegNo, int Effect)
        {
            this.RegNo = RegNo;
            this.Effect = Effect;
        }

        public virtual List<string> AboutMe()
        {
            return new List<string>() 
            { 
                $"RegNo:    {RegNo}",
                $"Effect:   {Effect}kw"
            };
        }
    }
}
