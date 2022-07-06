using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;

namespace PCGuide.Domain.Entities
{
    public class GPU : PCPartBase
    {
        public ushort MemoryCapacity { get; set; }

        public MemoryType MemoryType { get; set; }

        public TechnicalProcess TechnicalProcess { get; set; }

        public float ClockSpeed { get; set; }

        public ushort TDP { get; set; }

        public ushort Length { get; set; }
    }
}
