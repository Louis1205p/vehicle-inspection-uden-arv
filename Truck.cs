using System;

namespace ConsoleApp2
{
    public class Truck : Vehicle, IWheels
    {
        public int MaxRimSize { get; set; }

        public Truck(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection)
        { }

        public override string InspectionStatus()
        {
            if ((DateTime.Now - ProductionDate).Days > 365 && (DateTime.Now - LastInspection).Days > 365)
            {
                return "The truck needs inspection";
            }
            return "The truck doesn't need inspection.";
        }

        public override string DisplayInfo()
        {
            return $"Truck: {Brand} {Model}";
        }

        public void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 17 : 20;
            Console.WriteLine($"Truck Tire Type Set: {(isWinterTire ? "Winter Tire" : "Summer Tire")}, Max Rim Size: {MaxRimSize}");
        }
    }
}
