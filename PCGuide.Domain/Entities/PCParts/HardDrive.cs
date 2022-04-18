using PCGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Domain.Models
{
    public class HardDrive
    {
        public Guid Id { get; set; }

        public byte[]? Image { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public int Memory { get; set; }

        public int RPM { get; set; }
    }
}
