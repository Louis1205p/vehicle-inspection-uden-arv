using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main()
        {
            string carBrand = "Porsche";
            string carModel = "911";
            DateTime carProductionDate = new DateTime(2022, 12, 5);
            DateTime carLastInspection = new DateTime(2024, 8, 9);
            Vehicle car = new Car(carBrand, carModel, carProductionDate, carLastInspection);

            string truckBrand = "Toyota";
            string truckModel = "Truck";
            DateTime truckProductionDate = new DateTime(2022, 12, 5);
            DateTime truckLastInspection = new DateTime(2004, 8, 9);
            Vehicle truck = new Truck(truckBrand, truckModel, truckProductionDate, truckLastInspection);

            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine(car.InspectionStatus());
            ((IWheels)car).SetTireType(true);
            Console.WriteLine();
            Console.WriteLine(truck.DisplayInfo());
            Console.WriteLine(truck.InspectionStatus());
            ((IWheels)truck).SetTireType(false);

            Console.WriteLine();
            Console.WriteLine("Interface Info:");
            Console.WriteLine(car.GetInterfaceInfo((IWheels)car));
            Console.WriteLine(truck.GetInterfaceInfo((IWheels)truck));
        }
    }
}
