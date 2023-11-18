using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace postMortem.Data.Model
{
    public class Post : InteractiveEntity
    {
        public Post()
        {
            Title = "";
            Message = "";
            Tags = new List<Tag>(); // Initialize the Tags list here
        }

        public Post(string title, string message, User poster)
            : base(poster)
        {
            Title = title;
            Message = message;
            Tags = new List<Tag>(); // Also initialize the Tags list here
        }

        [Required]
        [StringLength(32, ErrorMessage = "Title too long (32 character limit).")]
        public string Title { get; set; }

        public string Message { get; set; }
        public bool MarkedNSFW { get; set; }
        public virtual List<Tag> Tags { get; private set; } // Tags list is initialized in constructors

        public override string EntityType => "Post";
    }
}
