using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;

namespace PCGuide.Domain.Entities
{
    public class CPUCooler : PCPartBase
    {
        public ushort TDP { get; set; }

        public ushort Height { get; set; }
    }
}