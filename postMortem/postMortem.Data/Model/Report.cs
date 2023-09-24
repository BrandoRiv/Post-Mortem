using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents a user report to a post, or comment that violates the community roles.
    /// </summary>
    public class Report : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Report"/> class. This constructor is required for entity framework to include it.
        /// </summary>
        public Report()
        {
            Reporter = null;
            Entity = null;
            Status = ReportStatus.Undecided;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Report"/> class. 
        /// </summary>
        /// <param name="reporter">The person reporting the entity.</param>
        /// <param name="entity">The entity being reported.</param>
        /// <param name="status">Status of this report.</param>
        public Report(User reporter, InteractiveEntity entity, ReportStatus status)
        {
            Reporter = reporter;
            Entity = entity;
            Status = status;
        }

        /// <summary>
        /// Person creating the report.
        /// </summary>
        [Required]
        public virtual User? Reporter { get; set; }

        /// <summary>
        /// Entity being reported.
        /// </summary>
        [Required]
        public virtual InteractiveEntity? Entity { get; set; }

        /// <summary>
        /// Short description on why the entity is being reported.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The current report status.
        /// </summary>
        public ReportStatus Status { get; set; }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        public override string EntityType => "Report";
    }
}
