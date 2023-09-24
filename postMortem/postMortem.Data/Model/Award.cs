using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        /// <summary>
        /// Initializes an instance of the <see cref="Award"/> class. This constructor is required for entity framework to include it.
        /// </summary>
        public Award() 
        {
            Name = "";
            Details = "";
            ImagePath = "~/Images/NoImage.png";
            RecipientNotified = false;
            Recipient = null;
            From = null;
        }

        /// <summary>
        /// Initializes an instance of the <see cref="Award"/> class.
        /// </summary>
        /// <param name="awardName">Name of the award.</param>
        /// <param name="awardDetails">Small description about the reward.</param>
        /// <param name="imagePath">Internal path of the image of the award.</param>
        /// <param name="recipient">The entity that is receiving it.</param>
        /// <param name="from">Who the award is from.</param>
        public Award(string awardName, string awardDetails, string imagePath, InteractiveEntity recipient, User from)
            : this()
        {
            Name = awardName;
            Details = awardDetails;
            ImagePath = imagePath;
            RecipientNotified = false;
            Recipient = recipient;
            From = from;
        }

        /// <summary>
        /// Name of the award.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Small details about the award.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Internal path to the image of this award.
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Has the recipient been notified of their award?
        /// </summary>
        public bool RecipientNotified { get; set; }

        /// <summary>
        /// The entity receiving the award.
        /// </summary>
        [Required]
        public virtual InteractiveEntity? Recipient { get; set; }

        /// <summary>
        /// The entity who provided the award.
        /// </summary>
        [Required]
        public virtual User? From { get; set; }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        public override string EntityType => "Award";
    }
}
