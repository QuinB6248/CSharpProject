using System.Collections.Generic;

namespace HappyVillageProject.Models
{
    public class Formats
    {
        public int FormatsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Images> Images { get; set; }
    }
}