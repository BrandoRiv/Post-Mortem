using System.ComponentModel.DataAnnotations.Schema;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Defines the base object required for an entity to be placed in a database.
    /// </summary>
    public abstract class Entity
    {
        public int ID { get; set; }

        [NotMapped]
        public abstract string EntityType { get; }
    }
}
