using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository
{
    using Microsoft.EntityFrameworkCore;
    using postMortem.Data.Model;
    using System.Linq.Expressions;

    /// <summary>
    /// Defines a EntityFramework database repository that requires an instance of <see cref="DbContext"/> class. Repository is the container for a database table.
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    public class EfRepository<TDbContext, TEntity> : IRepository<TEntity>
        where TDbContext : DbContext
        where TEntity : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EfRepository{TDbContext, TEntity}"/> class.
        /// </summary>
        /// <param name="context"></param>
        public EfRepository(TDbContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Save changes automatically when Add, Edit or Remove function is called.
        /// </summary>
        public bool SaveChangesOnAddEditRemove = false;

        /// <summary>
        /// Database context that this repository is defined in.
        /// </summary>
        public TDbContext Context { get; set; }

        /// <summary>
        /// Gets an entity based on ID.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public virtual TEntity Get(int ID)
        {
            return this.Context.Set<TEntity>().Find(ID);
        }

        /// <summary>
        /// Gets all entities within the repository.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return this.Context.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Finds a group of entities based on a predicate function.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        /// <summary>
        /// Returns the first or default value of a <see cref="TEntity"/> based on a predicate function.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TEntity FirstOrDefault(Func<TEntity, bool> predicate)
        {
            return Context.Set<TEntity>().FirstOrDefault(predicate);
        }

        /// <summary>
        /// Returns one entity or default value based on a predicate function.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        /// <summary>
        /// Adds a new child to the repository.
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);

            if (this.SaveChangesOnAddEditRemove)
                this.Context.SaveChanges();
        }

        /// <summary>
        /// Adds a collection of entities to the repository.
        /// </summary>
        /// <param name="entities"></param>
        public virtual void AddRange(params TEntity[] entities)
        {
            this.Context.Set<TEntity>().AddRange(entities);

            if (this.SaveChangesOnAddEditRemove)
                this.Context.SaveChanges();
        }

        /// <summary>
        /// Edit a item within the repository.
        /// </summary>
        /// <param name="newEntity"></param>
        public virtual void Update(TEntity newEntity)
        {
            if (newEntity == null)
                return;

            TEntity currentVal = Get(newEntity.ID);

            if (currentVal == null)
                throw new ArgumentNullException("Invalid entity. No entity exists by ID.");

            currentVal = newEntity;

            if (this.SaveChangesOnAddEditRemove)
                this.Context.SaveChanges();
        }

        /// <summary>
        /// Removes a certain entity from the repository.
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Remove(TEntity entity)
        {
            this.Context.Set<TEntity>().Remove(entity);

            if (this.SaveChangesOnAddEditRemove)
                this.Context.SaveChanges();
        }

        /// <summary>
        /// Removes a range of entities from the repository.
        /// </summary>
        /// <param name="entities"></param>
        public virtual void RemoveRange(IEnumerable<TEntity> entities)
        {
            this.Context.Set<TEntity>().RemoveRange(entities);

            if (this.SaveChangesOnAddEditRemove)
                this.Context.SaveChanges();
        }

        /// <summary>
        /// Removes all entities from the repository.
        /// </summary>
        public virtual void RemoveAll()
        {
            this.Context.Set<TEntity>().RemoveRange(this.GetAll());

            if (this.SaveChangesOnAddEditRemove)
                this.Context.SaveChanges();
        }

        /// <summary>
        /// Allows you to save the collection of entities.
        /// </summary>
        /// <remarks>Not supported in a List repository.</remarks>
        public virtual void SaveChanges()
        {
            this.Context.SaveChanges();
        }
    }
}
