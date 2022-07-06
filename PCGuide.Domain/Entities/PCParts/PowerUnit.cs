using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;

namespace PCGuide.Domain.Entities
{
    public class PowerUnit : PCPartBase
    {
        public ushort Power { get; set; }
    }
}