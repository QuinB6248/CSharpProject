using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyVillageProject.Models
{
    public class Images
    {
        public int ImagesId { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int FormatsId { get; set; }
        public Formats Formats{ get; set; }
        public int OwnersId { get; set; }
        public Owners Owners { get; set; }

    }

}
