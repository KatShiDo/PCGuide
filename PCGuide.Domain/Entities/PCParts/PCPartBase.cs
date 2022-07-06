using PCGuide.Domain.Enum;
using PCGuide.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace PCGuide.Domain.Entities
{
    public abstract class PCPartBase : EntityBase
    {
        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }
    }
}
