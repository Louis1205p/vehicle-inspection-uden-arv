using System;

namespace ConsoleApp2
{
    public class Car : Vehicle, IWheels
    {
        public int MaxRimSize { get; set; }

        public Car(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection)
        { }

        public override string InspectionStatus()
        {
            if ((DateTime.Now - ProductionDate).Days > 365 * 4 && (DateTime.Now - LastInspection).Days > 365 * 2)
            {
                return "The car needs inspection";
            }
            return "The car doesn't need inspection";
        }

        public override string DisplayInfo()
        {
            return $"Car: {Brand} {Model}";
        }

        public void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 16 : 22;
            Console.WriteLine($"Car Tire Type Set: {(isWinterTire ? "Winter Tire" : "Summer Tire")}, Max Rim Size: {MaxRimSize}");
        }
    }
}
