using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;

namespace PCGuide.Domain.Entities
{
    public class Frame : PCPartBase
    {
        public ushort Height { get; set; }

        public ushort Width { get; set; }

        public ushort Lenght { get; set; }

        public MotherboardType MotherboardType { get; set; }
    }
}