using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class DischargeDetails
    {
        public DateTime DischargeDate { get; set; }
        public string DischargeTime { get; set; }
        public string DischargeModeID { get; set; }
        public string ApprovalID { get; set; }

    }
}
