using PCGuide.Domain.Enum;
using System;

namespace PCGuide.Domain.Entities
{
    public class HardDrive
    {
        public Guid Id { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }

        public ushort MemoryCapacity { get; set; }

        public ushort RPM { get; set; }
    }
}