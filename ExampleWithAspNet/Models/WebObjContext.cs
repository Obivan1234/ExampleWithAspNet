using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ExampleWithAspNet.Models
{
    public class WebObjContext : DbContext
    {
        public WebObjContext() : base("Home")
        {
        }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => !String.IsNullOrEmpty(t.Namespace))
                .Where(t => t.BaseType != null && t.BaseType.IsGenericType &&
                t.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));


            foreach (var item in types)
            {
                dynamic instance = Activator.CreateInstance(item);
                modelBuilder.Configurations.Add(instance);
            }           
        }

        public System.Data.Entity.DbSet<ExampleWithAspNet.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<ExampleWithAspNet.Models.Location> Locations { get; set; }
    }
}