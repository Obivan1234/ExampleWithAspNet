using ExampleWithAspNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ExampleWithAspNet.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            this.ToTable("Locations");
            this.HasKey(h => h.Id);
            this.Property(p => p.Name).IsOptional();

            this.HasMany(p => p.People)
                .WithOptional(p => p.Location)
                .HasForeignKey(p => p.LocationId);
        }
    }
}