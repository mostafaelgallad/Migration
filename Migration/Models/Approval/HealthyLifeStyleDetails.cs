using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class HealthyLifeStyleDetails
    {
        public string PhysicalActivityID { get; set; }
        public string DietTypeID { get; set; }
        public string SportTypeID { get; set; }
        public string TabacoSmokingStatusID { get; set; }
        public string SmokingConsumptionID { get; set; }
        public string AllergyHistoryID { get; set; }
        public string referalOfAbuseID { get; set; }
        public string EposideOfTreatmentID { get; set; }
        public string PastMedicalHistoryID { get; set; }
        public string VascularProcedureID { get; set; }
        public string LocationOfImairmentID { get; set; }
        public string SubstanceAbuseHistoryID { get; set; }
        public DateTime DateOfCommencement { get; set; }
        public string TimeOfCommencement { get; set; }
        public string ApprovalID { get; set; }

    }
}
