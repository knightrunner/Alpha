﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Knightrunner.Library.UserAccounting
{
    [DataContract(Namespace = "Knightrunner.Library.UserAccounting")]
    public class UserAccountInfo
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string AddressLine1 { get; set; }
        [DataMember]
        public string AddressLine2 { get; set; }
        [DataMember]
        public string AddressLine3 { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string CountryCode { get; set; }
        [DataMember]
        public string Telephone1 { get; set; }
        [DataMember]
        public string Telephone2 { get; set; }
        [DataMember]
        public DateTime CreationDate { get; set; }
        [DataMember]
        public DateTime? LastActivityDate { get; set; }
        [DataMember]
        public DateTime? LastLoginDate { get; set; }
        [DataMember]
        public DateTime? LastPasswordChangeDate { get; set; }
        [DataMember]
        public DateTime? ExpireDate { get; set; }
    }
}
