using Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Exceptions;

namespace Homework.Models
{
    internal class Database<T> where T : class , IEntity
    {
        private List<T> _entities;

        public Database()
        {
            _entities = new List<T>();
        }

        public void Add(T entity, Predicate<T> predicate)
        {
            if (entity == null)
                throw new NullReferenceException("null ola bilmez");

            if (_entities.Exists(predicate))
                throw new AlreadyExistsException("bu adda kitab var");

            _entities.Add(entity);
        }
        public T Get(Predicate<T> predicate)
        {
            return _entities.Find(predicate);
        }
        public List<T> GetAll(Predicate<T> predicate)
        {
            List<T> entitiesCopy = new List<T>();
            entitiesCopy.AddRange(_entities.FindAll(predicate));

            return entitiesCopy;
        }
        public void Delete(Predicate<T> predicate)
        {
            T entity = _entities.Find(predicate);
            if (entity == null)
                throw new NotFoundException("bu idli kitab yoxdur");

            _entities.Remove(entity);
        }
    }
}
