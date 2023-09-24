using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    public interface IEntity
    {
        int ID { get; set; }
        DateTime CreatedAt { get; set; }
        string EntityType { get; }
    }
}
