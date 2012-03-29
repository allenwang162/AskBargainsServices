using System.Runtime.Serialization;

namespace AskBargainsServices.DataContracts
{
    // ItemInfo DataContract
    [DataContract]
    public class DataInfo
    {        

        [DataMember]
        public string ItemID { get; set; }

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
        public string PublishDate { get; set; }

        [DataMember]
        public string ExpireDate { get; set; }

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
        public string CONDITION { get; set; }

        [DataMember]
        public string WARRANTY { get; set; }

        [DataMember]
        public string UserRated { get; set; }

        [DataMember]
        public string Today { get; set; }
    }
}