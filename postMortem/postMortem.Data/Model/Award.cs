using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents an appreciation vote from a user. These normally cost some money.
    /// </summary>
    public class Award : Entity
    {
        public Award() { }
        public Award(string name, string details)
        {
            Name = name;
            Details = details;
        }

        public string Name { get; set; }
        public string Details { get; set; }

        public virtual VoteableEntity To { get; set; }
        public int? ToID { get; set; }

        public virtual User From { get; set; }
        public int? FromID { get; set; }

        public override string EntityType => "Award";
    }
}
