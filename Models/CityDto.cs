using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace City3.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Description { get; set;  }

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }
        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; } = new List<PointOfInterestDto>() ; 

    }
}
