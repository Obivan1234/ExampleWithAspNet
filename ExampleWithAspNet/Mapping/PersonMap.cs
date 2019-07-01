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
            this.Property(p => p.Name).IsRequired();
            this.Property(p => p.Age).IsRequired();
            this.Property(p => p.FullName).IsRequired();
            this.Property(p => p.Location).IsRequired();
            this.Property(p => p.MaleOrFemale).IsRequired();
        }
    }
}