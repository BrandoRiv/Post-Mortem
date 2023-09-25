using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Defines the base object required for an entity to be placed in a database.
    /// </summary>
    public interface IEntity
    {
        int ID { get; set; }
        DateTime CreatedAt { get; set; }
        string EntityType { get; }
    }
}
