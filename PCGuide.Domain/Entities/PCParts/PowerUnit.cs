using PCGuide.Domain.Enum;
using System;

namespace PCGuide.Domain.Entities
{
    public class PowerUnit
    {
        public Guid Id { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }

        public ushort Power { get; set; }
    }
}