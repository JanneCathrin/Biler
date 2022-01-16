using System;

namespace GETA_PP_Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Spawn vehicles.
            Car car1 = new (RegNo: "NF123456", Effect: 147, MaxSpeed: 200, Color: "green");
            Car car2 = new (RegNo: "NF654321", Effect: 150, MaxSpeed: 195, Color: "blue");
            Plane plane = new (RegNo: "LN1234", Effect: 1000, WingSpan: 30, CarryingCapacity: 2, OwnWeight: 10);
            Boat boat = new (RegNo: "ABC123", Effect: 100, MaxSpeed: 30, GrossTonnage: 500);

            // - Printe informasjon om bil, båt, fly etc.
            Console.WriteLine("Car 1:");
            PrintDetails(car1, 8);
            Console.WriteLine("Car 2:");
            PrintDetails(car2, 8);
            Console.WriteLine("Plane:");
            PrintDetails(plane, 8);
            Console.WriteLine("Boat:");
            PrintDetails(boat, 8);
            // - Sammenlikne de to bilene, sjekke om de er samme kjøretøy.
            bool isSameCar = car1.RegNo == car2.RegNo;
            Console.WriteLine(isSameCar ? "The cars are the same." : "The cars are not the same.");
            // - Konsollprogrammet skal be flyet om å fly og printe dette i konsollet.
            plane.InitiateTakeOff();
            // - Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet  
            car1.StartDriving();
        }

        public static void PrintDetails(Vehicle vehicle, int indent = 0)
        {
            string indentString = "";

            for (int i = 0; i < indent; i++)
            {
                indentString += " ";
            }

            foreach (string s in vehicle.AboutMe())
            {
                Console.WriteLine(indentString + s);
            }
        }

        public static void myThing(int myOptional = 1, int myOptionalTwo = 2)
        {
            Console.WriteLine($"1: {myOptional} | 2: {myOptionalTwo}");
        }
    }
}
