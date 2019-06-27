using ExampleWithAspNet.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleWithAspNet.Models
{
    public class School : BaseEntity
    {
        public String  Name { get; set; }
        public int ZipCode { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}