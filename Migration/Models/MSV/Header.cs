using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models.MSV
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
        public int ChannelID { get; set; }
        public string CorrelationID { get; set; }
        public string Version { get; set; }
        public int MsvPsvID { get; set; }
        public DateTime? MSVExpiryDate { get; set; }
        public int MsvTypeID { get; set; }
        public string MsvTypeName { get; set; }
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
        public string BenfitTypeID { get; set; }
        public string BenfitTypeCode { get; set; }
        public string BenfitTypeCodeParty { get; set; }
        public string BenfitTypeName { get; set; }
        public string BenfitTypeNameParty { get; set; }

    }
}
