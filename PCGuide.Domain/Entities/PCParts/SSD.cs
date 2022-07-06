using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;

namespace PCGuide.Domain.Entities
{
    public class SSD : PCPartBase
    {
        public ushort MemoryCapacity { get; set; }

        public uint WriteSpeed { get; set; }

        public uint ReadSpeed { get; set; }
    }
}