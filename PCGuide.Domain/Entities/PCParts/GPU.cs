using PCGuide.Domain.Enum;
using System;

namespace PCGuide.Domain.Entities
{
    public class GPU
    {
        public Guid Id { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }

        public ushort MemoryCapacity { get; set; }

        public MemoryType MemoryType { get; set; }

        public TechnicalProcess TechnicalProcess { get; set; }

        public float ClockSpeed { get; set; }

        public ushort TDP { get; set; }

        public ushort Length { get; set; }
    }
}
