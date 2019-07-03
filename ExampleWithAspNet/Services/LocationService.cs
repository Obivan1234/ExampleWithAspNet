using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExampleWithAspNet.Infrastructure;
using ExampleWithAspNet.Models;

namespace ExampleWithAspNet.Services
{
    public class LocationService : ILocationServise
    {
        private IRepository<Location> _locationRepository;

        public LocationService( IRepository<Location> locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public IEnumerable<Location> GetLocations()
        {
            return _locationRepository.Get();
        }
    }
}