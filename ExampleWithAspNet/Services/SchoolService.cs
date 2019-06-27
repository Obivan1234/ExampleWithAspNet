using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExampleWithAspNet.Infrastructure;
using ExampleWithAspNet.Models;

namespace ExampleWithAspNet.Services
{
    public class SchoolService : ISchoolService
    {
        private IRepository<School> repository;


        public SchoolService(IRepository<School> repository)
        {
            this.repository = repository;
        }

        public School GetSchoolById(int id)
        {
            return repository.FindById(id);
        }

        public IEnumerable<School> GetSchools(Func<School, bool> predicate)
        {
            return repository.Get(predicate);
        }
    }
}