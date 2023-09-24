using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository.Instance
{
    public class SubscriptionRepository : EfRepository<postMortemContext, Subscription>
    {
        public SubscriptionRepository(postMortemContext context) : base(context)
        {
        }
    }
}
