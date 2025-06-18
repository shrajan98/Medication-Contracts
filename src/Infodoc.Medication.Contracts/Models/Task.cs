using System;
using System.Collections.Generic;
using System.Text;

namespace Infodoc.Medication.Contracts.Models
{
    public class Task
    {
        public string TaskId { get; set; }
        public string TaskDate { get; set; }
        public string TaskPriority { get; set; }
        public string TaskSubject { get; set; }
        public string TaskBody { get; set; }
        public string TaskType { get; set; }
        public Patient Patient { get; set; }
    }
}
