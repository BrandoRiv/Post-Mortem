using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    public class Report : Entity
    {
        public Report()
        {

        }

        public virtual VoteableEntity Entity { get; set; }
        public int? EntityID { get; set; }

        public virtual User User { get; set; }
        public int? UserID { get; set; }

        public bool Archived { get; set; }
        public bool Deleted { get; set; }

        public ReportStatus Status { get; set; }

        public override string EntityType => "Report";
    }
}
