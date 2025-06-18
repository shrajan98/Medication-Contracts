using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Infodoc.Medication.Contracts.Models
{
    [DataContract]
    public class PatientTicket
    {
        [DataMember(Name = "patientPid")]
        public string PatientPid { get; set; }

        [DataMember(Name = "errorMessage")]
        public string ErrorMessage { get; set; }


    }
}
