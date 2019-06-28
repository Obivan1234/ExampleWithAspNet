using ExampleWithAspNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ExampleWithAspNet.Mapping
{
    public class SchoolMap : EntityTypeConfiguration<School>
    {
        public SchoolMap()
        {
            this.ToTable("Schools");
            this.HasKey(h => h.Id);
            this.Property(p => p.Name);
            this.Property(p => p.ZipCode);
            this.Property(p => p.Grande);

            this.HasMany(p => p.Students)
                 .WithOptional(p => p.School)
                 .HasForeignKey(p => p.SchoolId);
        }
    }
}