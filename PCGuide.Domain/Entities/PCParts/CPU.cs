using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;

namespace PCGuide.Domain.Entities
{
    public class CPU : PCPartBase
    {
        public Series Series { get; set; }

        public Socket Socket { get; set; }

        public TechnicalProcess TechnicalProcess { get; set; }

        public ushort CoresCount { get; set; }

        public ushort ThreadsCount { get; set; }

        public ushort CacheCapacity { get; set; }

        public bool HaveIntegratedGraphics { get; set; }

        public IntegratedGraphics IntegratedGraphics { get; set; }

        public float ClockSpeed { get; set; }

        public float BoostClockSpeed { get; set; }

        public ushort TDP { get; set; }

        public MemoryType RAMType { get; set; }

        public ushort RAMThreads { get; set; }
    }
}
