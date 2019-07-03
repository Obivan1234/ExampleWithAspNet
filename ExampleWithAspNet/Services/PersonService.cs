using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExampleWithAspNet.Infrastructure;
using ExampleWithAspNet.Models;

namespace ExampleWithAspNet.Services
{
    public class PersonService : IPersonService
    {
        private IRepository<Person> _personRepository;

        public PersonService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public Person GetPersonById(int id)
        {
            return _personRepository.FindById(id);
        }

        public IEnumerable<Person> GetPersones()
        {
            return _personRepository.GetWithInclude(p => p.Location);
        }

        public void InsertPerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException("person", "Does not consist");
            }
            else
            {
                _personRepository.Create(person);
            }
        }

        public void Remove(Person person)
        {
            _personRepository.Delete(person);
        }

        public void Update(Person person)
        {
            _personRepository.Update(person);
        }
    }
}