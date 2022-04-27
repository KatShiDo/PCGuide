using PCGuide.Domain.Enum;
using System;

namespace PCGuide.Domain.Entities
{
    public class Frame
    {
        public Guid Id { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }

        public ushort Height { get; set; }

        public ushort Width { get; set; }

        public ushort Lenght { get; set; }

        public MotherboardType MotherboardType { get; set; }
    }
}