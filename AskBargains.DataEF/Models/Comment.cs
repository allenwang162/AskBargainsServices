using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AskBargains.DataEF.Models
{
    [DataContract]
    public class Comment
    {
        [Key]
        [DataMember]
        public int CommentId { get; set; }

        [DataMember]
        public long DataItemId { get; set; }

        [DataMember]
        public string CommentText { get; set; }

        [DataMember]
        public DateTime AddedOn { get; set; }

        [DataMember]
        public string Commentator { get; set; }

    }
}
