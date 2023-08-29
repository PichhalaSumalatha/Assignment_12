using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assesment_12.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string PublicationDate { get; set; }

        // Foreign key to relate comments to a post
        public int PostId { get; set; }
        

    }
}