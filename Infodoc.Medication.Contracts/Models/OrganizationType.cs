using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infodoc.Medication.Contracts.Models
{
    public enum OrganizationType
    {
        PLO = 1,
        Sykehus,
        Fastlege,
        Legevakt,
        Helsestasjon,
        Tannlege,
        Helsehus,
        Spesialist,
        Annet = 99
    }
}
