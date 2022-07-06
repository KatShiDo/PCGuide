using PCGuide.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Domain.Entities
{
    public class EntityBase : IIdentifiable
    {
        public Guid Id { get; set; }
    }
}
