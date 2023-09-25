using System.ComponentModel.DataAnnotations.Schema;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Defines the base object required for an entity to be placed in a database.
    /// </summary>
    public abstract class Entity : IEntity
    {
        /// <summary>
        /// The default primary key of each table.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The date this entity was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        [NotMapped]
        public abstract string EntityType { get; }
    }
}
