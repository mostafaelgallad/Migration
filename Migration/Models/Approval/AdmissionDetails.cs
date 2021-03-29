using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class AdmissionDetails
    {
        public DateTime? AdmissionDate { get; set; }
        public string AdmissionTime { get; set; }
        public string AdmissionTypeID { get; set; }
        public string AdmissionTypeCode { get; set; }
        public string AdmissionTypeCodeParty { get; set; }
        public string AdmissionTypeName { get; set; }
        public string AdmissionTypeNameParty { get; set; }
        public string ExtendedWaitPatientID { get; set; }
        public string EstimatedLengthOfStay { get; set; }
        public string EstimatedLengthOfStayUnitID { get; set; }
        public string EstimatedLengthOfStayUnitCode { get; set; }
        public string EstimatedLengthOfStayUnitCodeParty { get; set; }
        public string EstimatedLengthOfStayUnitName { get; set; }
        public string EstimatedLengthOfStayUnitNameParty { get; set; }
        public string AmbulatoryCareInformationID { get; set; }
        public string ExternalCauseID { get; set; }
        public DateTime? ScheduledAdmissionDate { get; set; }
        public string ClinicalComplexityID { get; set; }
        public string EncounterTypeID { get; set; }
        public string BedNumber { get; set; }
        public string RoomNumber { get; set; }
        public string ApprovalID { get; set; }

    }
}
