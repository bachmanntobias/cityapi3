using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace City3.API.Models
{
    public class PointOfInterestForCreationDto
    {
        [Required]
        [MaxLength(50)]

        public String Name { get; set; }

        [MaxLength(200)]
        public String Description { get; set; }

    

    }
}
