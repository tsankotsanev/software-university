﻿namespace _02.Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FUEL_CONSUMPTION_MODIFIER = 1.6;
        private const bool hole = true;
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
            FuelConsumption += FUEL_CONSUMPTION_MODIFIER;
        }

        public override bool Hole => hole;
    }
}
