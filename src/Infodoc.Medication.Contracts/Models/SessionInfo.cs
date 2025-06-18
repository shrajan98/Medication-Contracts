using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Infodoc.Medication.Contracts.Models
{
    [DataContract]
    public class SessionInfo
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "clientAddress")]
        public string ClientAddress { get; set; }

        [DataMember(Name = "apiAddress")]
        public string ApiAddress { get; set; }

        [DataMember(Name = "metadata")]
        public Metadata Metadata { get; set; }

        [DataMember(Name = "expiresIn")]
        public TimeSpan ExpiresIn {  get; set; }

        [DataMember(Name = "ErrorMessage")]
        public string ErrorMessage { get; set; }

    }

    [DataContract]
    public class Metadata
    {
        [DataMember(Name = "displayportal")]
        public string DisplayPortal { get; set; }

        [DataMember(Name = "patientportal")]
        public string PatientPortal { get; set; }

        [DataMember(Name = "healthcareportal")]
        public string HealthcarePortal { get; set; }

        [DataMember(Name = "enterpriseportal")]
        public string EnterprisePortal { get; set; }
    }
}
