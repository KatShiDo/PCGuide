using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;

namespace PCGuide.Domain.Entities
{
    public class RAM : PCPartBase
    {
        public MemoryType MemoryType { get; set; }

        public uint ClockSpeed { get; set; }

        public ushort Delay { get; set; }

        public ushort MemoryCapacity { get; set; }
    }
}