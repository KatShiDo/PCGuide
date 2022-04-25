using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Domain.Entities
{
    public class CPU
    {
        public Guid Id { get; set; }

        public byte[]? Image { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public string Series { get; set; }

        public string Socket { get; set; }

        public string TechnicalProcess { get; set; }

        public int CoresCount { get; set; }

        public int ThreadsCount { get; set; }

        public double L1CacheCapacity { get; set; }

        public double L2CachCapacity { get; set; }

        public double L3CacheCapacity { get; set; }

        public bool HaveIntegratedGraphics { get; set; }

        public string IntegratedGraphics { get; set; }

        public double ClockSpeed { get; set; }

        public double? BoostClockSpeed { get; set; }

        public int TDP { get; set; }

        public MemoryType RAMType { get; set; }

        public int RAMThreads { get; set; }
    }
}
