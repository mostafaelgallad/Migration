using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class Services
    {
        public string TotalRequestedCostCurrency { get; set; }
        public decimal TotalRequestedCostAmount { get; set; }
        public string TotalApprovedCostCurrency { get; set; }
        public decimal TotalApprovedCostAmount { get; set; }
        public string ReferralReasonID { get; set; }
        public string ReferralReasonName { get; set; }
        public string ReferralModeID { get; set; }
        public string ReferralModeName { get; set; }
        public string ReferralModeOther { get; set; }
        public string ApprovalID { get; set; }
    }
}
