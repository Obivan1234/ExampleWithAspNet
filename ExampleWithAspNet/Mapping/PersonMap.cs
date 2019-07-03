using ExampleWithAspNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ExampleWithAspNet.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            this.ToTable("Persons");
            this.HasKey(h => h.Id);
            this.Property(p => p.Name).IsOptional();
            this.Property(p => p.Age).IsOptional();
            this.Property(p => p.FullName).IsOptional();
            this.Property(p => p.Gender).IsOptional();          
        }
    }
}