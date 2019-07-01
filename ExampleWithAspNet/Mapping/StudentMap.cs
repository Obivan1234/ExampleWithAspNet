using ExampleWithAspNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;


namespace ExampleWithAspNet.Mapping
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            this.ToTable("Students");
            this.HasKey(h => h.Id);
            this.Property(p => p.Graduete).IsRequired();            
            this.Property(p => p.Name).IsRequired();
            this.Property(p => p.Age).IsRequired();
        }
    }
}