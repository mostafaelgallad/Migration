using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models.MSV
{
    [Keyless]
    public class TableOfBenefit
    {
        public string MaxPhysicianFee { get; set; }
        public string PreAuthorizationLimit { get; set; }
        public string Deductible { get; set; }
        public string MPNDeductible { get; set; }
        public string OHNDeductible { get; set; }
        public string OCNDeductible { get; set; }
        public string Copayment { get; set; }
        public string TreatmentExpenses { get; set; }
        public string DeductibleTobeCollected { get; set; }
        public string ScheduleOfBenefit { get; set; }
        public int MsvPsvID { get; set; }

    }
}
