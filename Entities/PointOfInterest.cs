using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace City3.API.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public String Name { get; set; }

        [MaxLength(200)]
        public String Description { get; set;  }

        [ForeignKey("CityId")]
        public City City { get; set; }

        public int CityId { get; set; }

    }
}
