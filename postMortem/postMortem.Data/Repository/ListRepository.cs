using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace postMortem.Data.Repository
{
    /// <summary>
    /// Provides a client-sided data repository. Does not work with database solutions, 
    /// but provides a convienent way to manaage a repository from a XML or List object.
    /// </summary>
    /// <typeparam name="TEntity">Type of child entity.</typeparam>
    public class ListRepository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        /// <summary>
        /// Private List<T> to use for reference.
        /// </summary>
        private List<TEntity> _Entities = new List<TEntity>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="entities"></param>
        public ListRepository(List<TEntity> entities)
        {
            _Entities = entities;
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="ListRepository{TEntity}"/> class.
        /// </summary>
        /// <remarks></remarks>
        public ListRepository()
        {

        }

        /// <summary>
        /// Adds a new child to the repository.
        /// </summary>
        /// <param name="entity"></param>
        public void Add(TEntity entity)
        {
            _Entities.Add(entity);
        }

        /// <summary>
        /// Adds a collection of entities to the repository.
        /// </summary>
        /// <param name="entities"></param>
        public void AddRange(params TEntity[] entities)
        {
            _Entities.AddRange(entities);
        }

        /// <summary>
        /// Edit a item within the repository.
        /// </summary>
        /// <param name="newEntity"></param>
        /// <remarks>Important: This is not supported in a List repository.</remarks>
        public void Update(TEntity newEntity)
        {
            var entity = this._Entities.FirstOrDefault(e => e.ID == newEntity.ID);
            int index = this._Entities.IndexOf(entity);

            this._Entities[index] = newEntity;
        }

        /// <summary>
        /// Finds a group of entities based on a predicate function.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _Entities.FindAll(new Predicate<TEntity>(predicate));
        }

        /// <summary>
        /// Returns the first or default value of a <see cref="TEntity"/> based on a predicate function.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TEntity FirstOrDefault(Func<TEntity, bool> predicate)
        {
            IEnumerable<TEntity> val = Find(predicate);

            if (val == null)
                return default(TEntity);
            else
                return ((List<TEntity>)val)[0];
        }

        /// <summary>
        /// Gets an entity based on ID.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public TEntity Get(int ID)
        {
            return FirstOrDefault(g => ((TEntity)g).ID == ID);
        }

        /// <summary>
        /// Gets all entities within the repository.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return _Entities;
        }

        /// <summary>
        /// Removes a certain entity from the repository.
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(TEntity entity)
        {
            _Entities.Remove(entity);
        }

        /// <summary>
        /// Removes all entities from the repository.
        /// </summary>
        public void RemoveAll()
        {
            _Entities.Clear();
        }

        /// <summary>
        /// Removes a range of entities from the repository.
        /// </summary>
        /// <param name="entities"></param>
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var val in entities)
                _Entities.Remove(val);
        }

        /// <summary>
        /// Allows you to save the collection of entities.
        /// </summary>
        /// <remarks>Not supported in a List repository.</remarks>
        public virtual void SaveChanges()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Returns one entity or default value based on a predicate function.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return FirstOrDefault(new Func<TEntity, bool>(predicate.Compile()));
        }
    }
}
