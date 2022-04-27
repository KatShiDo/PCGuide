using PCGuide.Domain.Enum;
using System;

namespace PCGuide.Domain.Entities
{
    public class RAM
    {
        public Guid Id { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }

        public MemoryType MemoryType { get; set; }

        public uint ClockSpeed { get; set; }

        public ushort Delay { get; set; }

        public ushort MemoryCapacity { get; set; }
    }
}