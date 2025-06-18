using System;
using System.Collections.Generic;
using System.Text;

namespace Infodoc.Medication.Contracts.Models
{
    public class ClinicInfo
    {
        public Guid JournalId { get; set; }
        public bool SfmStatusActive { get; set; }
        public bool tenantStatus { get; set; }
        public string? Status { get; set; }
        public UserInfo? UserInfo { get; set; }
        public bool UserAvailableInTenant { get; set; } = true;
        public bool LoggedInLocally { get; set; }

    }

    public class UserInfo
    {
        public bool IsUserInSfm { get; set; }

        public bool IsAdminInSfm { get; set; }

    }

}