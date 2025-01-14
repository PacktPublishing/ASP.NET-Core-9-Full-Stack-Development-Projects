﻿using Chapter9.Interfaces;

namespace Chapter9.Models
{
    public class Shipment : IShipment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
