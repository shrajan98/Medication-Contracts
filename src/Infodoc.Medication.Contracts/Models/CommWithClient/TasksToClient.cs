using System;
using System.Collections.Generic;

namespace Infodoc.Medication.Contracts.Models.CommWithClient
{
    public class ClientTasks
    {
        public List<Practitioner>? Practitioners { get; set; } = new();
    }

    public class Practitioner
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Signature { get; set; }
        public long Fnr { get; set; }
        public int Hpr { get; set; }
        public List<SfmTask>? Tasks { get; set; } = new();
        public List<FireAndForget>? FireAndForgets { get; set; } = new();
    }

    public class SfmTask
    {
        public string? TaskId { get; set; }
        public DateTime TaskDate { get; set; }
        public string? TaskPriority { get; set; }
        public string? TaskSubject { get; set; }
        public string? TaskBody { get; set; }
        public string? TaskType { get; set; }      
        public Patient? Patient { get; set; }
    }

    public class Patient
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public Guid PersonCardIndexId { get; set; }
    }

    public class FireAndForget
    {
        public string? FnF_Id { get; set; }
        public DateTime FnF_Date { get; set; }
        public string? FnF_Source { get; set; }
        public string? FnF_Subject { get; set; }
        public string? FnF_Body { get; set; }
    }

    public class PatientIdentifierInfo : Patient
    {
        public string? System { get; set; }
        public string? Identification { get; set; }
    }
}
