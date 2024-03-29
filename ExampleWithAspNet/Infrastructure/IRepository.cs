﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleWithAspNet.Infrastructure
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Update(T item);
        void Create(T item);
        void Delete(T item);
        T FindById(int id);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Func<T, bool> predicate);
    }
}