using System.Runtime.Serialization;

namespace AskBargainsServices.DataContracts
{
    public class CompanyInfo
    {
        [DataMember]
        public string CompanyID { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public string WebSiteUrl { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}