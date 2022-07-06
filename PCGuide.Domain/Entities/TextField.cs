using System;

namespace PCGuide.Domain.Entities
{
    public class TextField : EntityBase
    {
        public string CodeWord { get; set; }

        public string Title { get; set; } = "Информационная страница";

        public string Text { get; set; } = "Содержание заполняется администратором";

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }

        public string MetaKeywords { get; set; }
    }
}
