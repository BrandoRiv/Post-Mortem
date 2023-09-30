using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    public class Tag : Entity
    {
        public Tag() { }
        public Tag(string name,string description) 
        { 
            this.Name = name;
            this.Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public override string EntityType => "Tag";
    }
}
