using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;

namespace PCGuide.Domain.Entities
{
    public class Motherboard : PCPartBase
    { 
        public Socket Socket { get; set; }

        public Chipset Chipset { get; set; }

        public MemoryType MemoryType { get; set; }

        public MotherboardType MotherboardType { get; set; }
    }
}