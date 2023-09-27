using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository
{
    public class AwardRepository : postMortemRepository<Award>, IAwardRepository
    {
        public AwardRepository(postMortemContext context) : base(context)
        {
        }
    }
}
