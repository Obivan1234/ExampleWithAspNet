using ExampleWithAspNet.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleWithAspNet.Models
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}