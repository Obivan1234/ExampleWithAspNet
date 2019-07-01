using ExampleWithAspNet.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleWithAspNet.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Graduete { get; set; }

        public int? SchoolId { get; set; }
        public School School { get; set; }
    }
}