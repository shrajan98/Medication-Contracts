using System;
using System.Collections.Generic;
using System.Text;

namespace Infodoc.Medication.Contracts.Models
{
    public class LibInfoDto
    {
        public bool SfmDown {  get; set; }
        public DateTime LastUpdatedTimeStamp { get; set; }
        public List<Prescription>? PrescriptionList { get; set; }

    }

    public class Prescription
    {
        public string? Text { get; set; }
        /// <summary>
        /// Navn
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// DosVeiledEnkel
        /// </summary>
        public string? Dssn { get; set; }
        /// <summary>
        /// BruksomradeTekst
        /// </summary>
        public string? ApplicationArea { get; set; }
        /// <summary>
        /// Legemiddelform V
        /// </summary>
        public string? FormValue { get; set; }
        /// <summary>
        /// Legemiddelform DN
        /// </summary>
        public string? FormDescription { get; set; }
        /// <summary>
        /// Styrke V
        /// </summary>
        public string? StrengthValue { get; set; }
        /// <summary>
        /// Styrke U
        /// </summary>
        public string? StrengthUnit { get; set; }
        /// <summary>
        /// DoseringStarttidspunkt
        /// </summary>
        public string? DosageStartDate { get; set; }
        /// <summary>
        /// ATC V
        /// </summary>
        public string? AtcValue { get; set; }
        /// <summary>
        /// ATC DN
        /// </summary>
        public string? AtcDescription { get; set; }
        /// <summary>
        /// GeneriskNavn
        /// </summary>
        public string? GenericName { get; set; }
        /// <summary>
        /// Bruk V
        /// </summary>
        public string? UseValue { get; set; }
        /// <summary>
        /// Bruk DN
        /// </summary>
        public string? UseDescription { get; set; }
        public string? NameFormStrength { get; set; }
        public string? ReseptDate { get; set; }

    }
}
