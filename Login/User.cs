using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Login
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string uname { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string pwd { get; set; }
        [DataMember]
        public string fullname { get; set; }
        [DataMember]
        public bool active { get; set; }
        [DataMember]
        public int rank { get; set; }
        [DataMember]
        public bool ban { get; set; }
        [DataMember]
        public string ipadd { get; set; }
        [DataMember]
        public DateTime regtime { get; set; }
        [DataMember]
        public DateTime logtime { get; set; }
    }
}