using System;
using System.Collections.Generic;

namespace Infodoc.Medication.Contracts.Models
{
    public class AllergyListDto
    {
        public bool SfmDown { get; set; }
        public DateTime LastUpdatedTimeStamp { get; set; }   
        public List<AllergyDto>? Allergies { get; set; }
    }

    public class AllergyDto
    {
        public string? Code { get; set; }
        public string? CavePresentation { get; set; }
        public string? CaveDescription { get; set; }
    }
}
