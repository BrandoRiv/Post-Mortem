using postMortem.Data.Model;
using postMortem.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository.Instance
{
    public class SubscriptionRepository : EfRepository<postMortemContext, Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(postMortemContext context) : base(context)
        {
        }
    }
}
