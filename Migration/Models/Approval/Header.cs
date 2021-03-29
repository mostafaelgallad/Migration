using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class Header
    {
        public int PayerID { get; set; }
        public string PayerName { get; set; }
        public bool PayerIsTPA { get; set; }
        public string PayerLogo { get; set; }
        public int TPAPayerID { get; set; }
        public string TPAPayerName { get; set; }
        public bool TPAIsTPA { get; set; }
        public string TPAPayerLogo { get; set; }
        public int ProviderID { get; set; }
        public string ProviderName { get; set; }
        public string ProviderCodePayer { get; set; }
        public int ProviderCategoryID { get; set; }
        public string ProviderLogo { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public DateTime? TransactionRequestDateTime { get; set; }
        public string TransactionTypeID { get; set; }
        public string TransactionTypeCode { get; set; }
        public string TransactionTypeCodeParty { get; set; }
        public string TransactionTypeName { get; set; }
        public string TransactionTypeNameParty { get; set; }
        public string ApprovalProcessorName { get; set; }
        public int ChannelID { get; set; }
        public string CorrelationID { get; set; }
        public string Version { get; set; }
        public string ApprovalID { get; set; }
        public long? ParentApprovalID { get; set; }
        public string ApprovalTypeID { get; set; }
        public string ApprovalTypeCode { get; set; }
        public string ApprovalTypeCodeParty { get; set; }
        public string ApprovalTypeName { get; set; }
        public string ApprovalTypeNameParty { get; set; }
        public string PhysicianID { get; set; }
        public string PhysicianName { get; set; }
        public string PhysicianCategoryID { get; set; }
        public string PhysicianCategoryCode { get; set; }
        public string PhysicianCategoryCodeParty { get; set; }
        public string PhysicianCategoryName { get; set; }
        public string PhysicianCategoryNameParty { get; set; }
        public string PhysicianSCFHS { get; set; }
        public string SpecialityID { get; set; }
        public string SpecialityCode { get; set; }
        public string SpecialityCodeParty { get; set; }
        public string SpecialityName { get; set; }
        public string SpecialityNameParty { get; set; }
        public string SubSpecialityID { get; set; }
        public string SubSpecialityCode { get; set; }
        public string SubSpecialityCodeParty { get; set; }
        public string SubSpecialityName { get; set; }
        public string SubSpecialityNameParty { get; set; }
        public string VisitTypeID { get; set; }
        public string VisitTypeCode { get; set; }
        public string VisitTypeCodeParty { get; set; }
        public string VisitTypeName { get; set; }
        public string VisitTypeNameParty { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitTime { get; set; }
        public string ReferalNo { get; set; }
        public string FollowUpNo { get; set; }
        public string UILayout { get; set; }
        public bool IsInPatient { get; set; }
        public bool IsFromReferal { get; set; }
        public bool IsMSVPSVRequired { get; set; }
        public bool IsLatest { get; set; }
        public bool IsParent { get; set; }
        public bool ApprovalInquiryAllow { get; set; }
        public bool IsVisible { get; set; }
        public string MsvPsvID { get; set; }

    }
}
