using PCGuide.Domain.Enum;
using System;

namespace PCGuide.Domain.Entities
{
    public class CPUCooler
    {
        public Guid Id { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }

        public ushort TDP { get; set; }

        public ushort Height { get; set; }
    }
}