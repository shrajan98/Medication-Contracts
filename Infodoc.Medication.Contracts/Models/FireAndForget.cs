using System;
using System.Collections.Generic;
using System.Text;

namespace Infodoc.Medication.Contracts.Models
{
    public class FireAndForget
    {
        public string FnF_Id { get; set; }
        public string FnF_Date { get; set; }
        public string FnF_Source { get; set; }
        public string FnF_Subject { get; set; }
        public string FnF_Body { get; set; }
        public string IsRead { get; set; }

    }
}
