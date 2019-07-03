using ExampleWithAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWithAspNet.Services
{
    public interface ILocationServise
    {
        IEnumerable<Location> GetLocations();
    }
}