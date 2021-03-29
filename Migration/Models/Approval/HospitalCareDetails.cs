using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class HospitalCareDetails
    {
        public string IntendedStayLengthID { get; set; }
        public string ExpectedStayLenthInDays { get; set; }
        public string InterhospitalContractedPatientID { get; set; }
        public string OperationTreatmentTime { get; set; }
        public string NumberOLeavePeriod { get; set; }
        public string PatientDays { get; set; }
        public string ExpectedLengthOfStay { get; set; }
        public string ApprovalID { get; set; }

    }
}
