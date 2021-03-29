using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class Diagnosis
    {
        public string DiagnosisCode { get; set; }
        public string DiagnosisDescription { get; set; }
        public DateTime? DiagnosisDate { get; set; }
        public string DiagnosisTypeID { get; set; }
        public string DiagnosisTypeName { get; set; }
        public string DiagnosisOnSetFlagID { get; set; }
        public string DiagnosisOnSetFlagCode { get; set; }
        public string DiagnosisOnSetFlagName { get; set; }
        public string MDBID { get; set; }
        public string MDBName { get; set; }
        public string MDCID { get; set; }
        public string MDCName { get; set; }
        public string DRGName { get; set; }
        public string DRGCode { get; set; }
        public bool IsUnacceptPrimaryDiagnosis { get; set; }
        public string ApprovalID { get; set; }

    }
}
