using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class ServiceItem
    {
        public string RelatedToTransactionTypeCodeParty { get; set; }
        public string RelatedToTransactionTypeName { get; set; }
        public string RelatedToTransactionTypeNameParty { get; set; }
        public string RelatedToApprovalID { get; set; }
        public decimal ServiceDecisionsApprovedQuantity { get; set; }
        public string ServiceDecisionsApprovedCostCurrency { get; set; }
        public decimal ApprovedCostAmount { get; set; }
        public DateTime? PayerServiceCommentDate { get; set; }
        public string PayerServiceCommentText { get; set; }
        public string ServiceStatusID { get; set; }
        public string ServiceStatusCode { get; set; }
        public string ServiceStatusCodeParty { get; set; }
        public string ServiceStatusName { get; set; }
        public string ServiceStatusNameParty { get; set; }
        public string ApprovalID { get; set; }

    }
}
