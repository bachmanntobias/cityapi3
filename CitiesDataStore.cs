using System;
using City3.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace City3.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities{get; set;}

    public CitiesDataStore()
    {
            Cities = new List<CityDto>()
            {
            new CityDto()
        {
            Id = 1,
            Name = "NY",
            Description =  "USA",
            PointsOfInterest = new List<PointOfInterestDto>()
            {
                new PointOfInterestDto()
                {
                    Id = 1,
                    Name = "Central Park",
                    Description = "empty",


                },
                   new PointOfInterestDto()
                {
                    Id = 2,
                    Name = "Puzzles",
                    Description = "Bar",

                }

            }
        },
                new CityDto()
        {
            Id = 2,
            Name = "Grosswallstadt",
            Description =  "Standort",
        },

                    new CityDto()
        {
            Id = 3,
            Name = "Frankfurt",
            Description =  "Hessen",
        },

            };
    }
    }
}
