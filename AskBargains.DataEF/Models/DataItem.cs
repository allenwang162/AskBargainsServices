﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AskBargains.DataEF.Models
{
    [DataContract]
    public class DataItem
    {
        [Key]
        [DataMember]
        public long DataItemId { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public string ImgPath { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string ItemDescription { get; set; }

        [DataMember]
        public string ForwardLink { get; set; }

        [DataMember]
        public string CouponCode { get; set; }

        [DataMember]
        public string OriginalPrice { get; set; }

        [DataMember]
        public string ItemPrice { get; set; }

        [DataMember]
        public DateTime PublishDate { get; set; }
        
        [DataMember]
        public DateTime ExpireDate { get; set; }

        [DataMember]
        public string ItemCategory { get; set; }

        [DataMember]
        public string SubCategory { get; set; }

        [DataMember]
        public string BrandName { get; set; }

        [DataMember]
        public string SKU { get; set; }

        [DataMember]
        public string ShowCoupons { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public string Promotion { get; set; }

        [DataMember]
        public string Save { get; set; }

        [DataMember]
        public string Rebate { get; set; }

        [DataMember]
        public string Shipping { get; set; }

        [DataMember]
        public string Condition { get; set; }

        [DataMember]
        public string Warranty { get; set; }

        [DataMember]
        public string UserRated { get; set; }

        [DataMember]
        public string Today { get; set; }

        [DataMember]
        public string MetaKeyword { get; set; }

        [DataMember]
        public string MetaDescription { get; set; }

        [DataMember]
        public string Others { get; set; }
     

        [DataMember]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
