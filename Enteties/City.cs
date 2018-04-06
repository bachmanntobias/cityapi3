using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace City3.API.Enteties
{
    public class City
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Description {get; set;}

        public ICollection<PointsOfInterest> PointsOfInterest { get; set; }
            = new List<PointsOfInterest>();
    }
}
