using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Domain.Entities
{
    public class TextField
    {
        public Guid Id { get; set; }

        public string CodeWord { get; set; }

        public string Title { get; set; } = "Информационная страница";

        public string Text { get; set; } = "Содержание заполняется администратором";
    }
}
