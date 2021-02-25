﻿using SundaySchoolManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SundaySchoolManagement.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Insert(T entity);
        T Update(T entity);
        void Delete(int id);
    }
}
