using postMortem.Data.Model;
using postMortem.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository.Instance
{
    public class CommentRepository : EfRepository<postMortemContext, Comment>, ICommentRepository
    {
        public CommentRepository(postMortemContext context) : base(context)
        {
        }
    }
}
