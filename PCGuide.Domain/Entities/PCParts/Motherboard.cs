using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Domain.Models
{
    public class Motherboard
    {
        public Guid Id { get; set; }

        public byte[]? Image { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public string Socket { get; set; }

        public string Chipset { get; set; }

        public MemoryType MemoryType { get; set; }

        public MotherboardType MotherboardType { get; set; }
    }
}
