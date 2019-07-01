﻿using ExampleWithAspNet.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleWithAspNet.Models
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string MaleOrFemale { get; set; }
        public string FullName { get; set; }
    }
}