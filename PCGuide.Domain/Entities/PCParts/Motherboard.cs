using PCGuide.Domain.Enum;
using System;

namespace PCGuide.Domain.Entities
{
    public class Motherboard
    {
        public Guid Id { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }

        public Socket Socket { get; set; }

        public Chipset Chipset { get; set; }

        public MemoryType MemoryType { get; set; }

        public MotherboardType MotherboardType { get; set; }
    }
}