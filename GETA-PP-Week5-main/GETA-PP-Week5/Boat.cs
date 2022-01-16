using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GETA_PP_Week5
{
    public class Boat : Vehicle
    {

        public int MaxSpeed;
        public int GrossTonnage;


     public Boat(string RegNo, int MaxSpeed, int Effect, int GrossTonnage) 
            : base(RegNo, Effect)
        {
            this.MaxSpeed = MaxSpeed;
            this.GrossTonnage = GrossTonnage;

        }

        public override List<string> AboutMe()
        {
            List<string> myDeets = base.AboutMe();

            myDeets.Add($"MaxSpeed:        {MaxSpeed}");
            myDeets.Add($"GrossTonnage:    {GrossTonnage}");

            return myDeets;
        }



    }
}
