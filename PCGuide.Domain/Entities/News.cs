using System;

namespace PCGuide.Domain.Entities
{
    public class News
    {
        public Guid Id { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string TagsString { get; set; }
    }
}