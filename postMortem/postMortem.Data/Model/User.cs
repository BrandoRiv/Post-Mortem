using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    public class User : Entity
    {
        public string Username { get; set; }
        public override string EntityType => "User";
    }
}
