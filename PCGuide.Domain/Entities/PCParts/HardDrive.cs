using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;

namespace PCGuide.Domain.Entities
{
    public class HardDrive : PCPartBase
    {
        public ushort MemoryCapacity { get; set; }

        public ushort RPM { get; set; }
    }
}