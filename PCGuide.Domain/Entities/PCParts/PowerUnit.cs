using PCGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Domain.Entities
{
    public class PowerUnit
    {
        public Guid Id { get; set; }

        public byte[]? Image { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public int Power { get; set; }
    }
}
