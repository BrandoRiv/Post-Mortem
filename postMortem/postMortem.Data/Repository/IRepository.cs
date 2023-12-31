﻿using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository
{
    public interface IRepository<TEntity> : IRepository<TEntity, int>
        where TEntity : IEntity<int>
    {

    }

    /// <summary>
    /// Defines the required properties for creating a repository object. Requires a child element type that derives <see cref="IEntity"/> interface.
    /// </summary>
    /// <typeparam name="TEntity">Type of child element that is derived from <see cref="IEntity"/></typeparam>
    public interface IRepository<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        TEntity Get(TKey ID);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);

        TEntity FirstOrDefault(Func<TEntity, bool> predicate);
        Task<TEntity> FirstOrDefaultAsync(Func<TEntity, bool> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(params TEntity[] entities);

        void Update(TEntity newEntity);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void RemoveAll();

        void SaveChanges();
    }
}
