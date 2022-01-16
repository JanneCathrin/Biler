using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GETA_PP_Week5
{
    public class Plane : Vehicle
    {
        public int WingSpan;
        public int CarryingCapacity;
        public int OwnWeight;
    

        public Plane(string RegNo, int Effect, int WingSpan, int CarryingCapacity, int OwnWeight)
            : base(RegNo, Effect)
        {
            this.WingSpan = WingSpan;
            this.CarryingCapacity = CarryingCapacity;
            this.OwnWeight = OwnWeight;
        }

        public override List<string> AboutMe()
        {
            List<string> myDeets = base.AboutMe();

            myDeets.Add($"Wing span:            {WingSpan}");
            myDeets.Add($"Carrying Capacity:    {CarryingCapacity}"); 
            myDeets.Add($"OwnWeight             {OwnWeight}");

            return myDeets;
        }

        public void InitiateTakeOff()
        {
            Console.WriteLine($"Plane {RegNo} is now taking off!");
        }
    }
}
