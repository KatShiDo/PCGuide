using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Domain.Entities
{
    public class Frame
    {
        public Guid Id { get; set; }

        public byte[]? Image { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public int Lenght { get; set; }

        public MotherboardType MotherboardType { get; set; }
    }
}
