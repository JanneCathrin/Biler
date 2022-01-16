using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GETA_PP_Week5
{
    public class Car : Vehicle
    {
        public string Color;
        public bool IsHeavy = false;
        public int MaxSpeed;

        public Car(string RegNo, int MaxSpeed, int Effect, string Color, bool IsHeavy = false)
            : base(RegNo, Effect)
        {
            this.Color = Color;
            this.IsHeavy = IsHeavy;
            this.MaxSpeed = MaxSpeed;
        }

        public override List<string> AboutMe()
        {
            List<string> myDeets = base.AboutMe();

            myDeets.Add($"Color:    {CapitaliseWord(Color)}");
            myDeets.Add($"MaxSpeed:   {MaxSpeed}km/h");
            myDeets.Add($"Is heavy: {(IsHeavy == true ? "Yes" : "No")}");

            return myDeets;
        }

        public string CapitaliseWord(string s)
        {
            char firstLetter = s.ToUpper().ElementAt(0);

            return firstLetter + s[1..];
        }

        internal void StartDriving()
        {
            Console.WriteLine($"Car {RegNo} drives off into the sunset.. And was never heard from again o0");
        }
    }
}
