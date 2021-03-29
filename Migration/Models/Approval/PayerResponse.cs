using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class PayerResponse
    {
        public DateTime? ResponseDateTime { get; set; }
        public string PayerReferenceNumber { get; set; }
        public string ApprovalStatusID { get; set; }
        public string ApprovalStatusCode { get; set; }
        public string ApprovalStatusCodeParty { get; set; }
        public string ApprovalStatusName { get; set; }
        public string ApprovalStatusNameParty { get; set; }
        public string ApprovalValidityPeriodDuration { get; set; }
        public string ApprovalValidityPeriodUnitCode { get; set; }
        public string ApprovedLengthOfStaySummaryDuration { get; set; }
        public string ApprovedLengthOfStaySummaryUnitCode { get; set; }
        public DateTime? RemarkCommentDate { get; set; }
        public string RemarkCommentText { get; set; }
        public string ApprovalID { get; set; }

    }
}
