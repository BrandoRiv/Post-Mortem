using System.ComponentModel.DataAnnotations.Schema;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Defines the base object required for an entity to be placed in a database.
    /// </summary>
    public abstract class Entity : Entity<int>
    {
    }

    /// <summary>
    /// Defines the base object required for an entity to be placed in a database.
    /// </summary>
    public abstract class Entity<TKey> : IEntity<TKey>
    {
        public Entity()
        {
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
        }

        /// <summary>
        /// The default primary key of each table.
        /// </summary>
        public TKey Id { get; set; }

        /// <summary>
        /// The date this entity was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// The date this entity was last modified.
        /// </summary>
        public DateTime ModifiedAt { get; set; }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        [NotMapped]
        public abstract string EntityType { get; }
    }
}
