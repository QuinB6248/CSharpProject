using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyVillageProject.Models
{
    public class Images
    {
        public int ImagesId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public int SubjectsId { get; set; }
        public Subjects Subjects { get; set; }
        //public int OwnersId { get; set; }
        //public Owners Owners { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Now { get;  }

    }

}
