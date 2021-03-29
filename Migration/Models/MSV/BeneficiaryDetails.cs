using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models.MSV
{
    [Keyless]
    public class BeneficiaryDetails
    {
        public byte? IdentityTypeID { get; set; }
        public string NationalID { get; set; }
        public string MaritalStatus { get; set; }
        public string PatientName { get; set; }
        public string Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int NationalityID { get; set; }
        public string NationalityName { get; set; }
        public string MobileNumber { get; set; }
        public string GenderName { get; set; }
        public string MemberType { get; set; }
        public string MembershipNumber { get; set; }
        public string MembershipMemberClass { get; set; }
        public DateTime? MembershipInceptionDate { get; set; }
        public DateTime? MembershipEndDate { get; set; }
        public string MembershipPolicyNumber { get; set; }
        public string MembershipPolicyHolderName { get; set; }
        public string MembershipPlanType { get; set; }
        public int MsvPsvID { get; set; }

    }
}
