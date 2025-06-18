using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infodoc.Medication.Contracts.Models
{
    public class PractitionerModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Signature { get; set; }
        public string Fnr { get; set; }
        public string Hpr { get; set; }
        public List<Task> Tasks { get; set; }
        public List<FireAndForget> FireAndForgets { get; set; }
    }
}
