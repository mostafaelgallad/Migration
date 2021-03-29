using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class ApprovalCancellationRemarks
    {
        public string RemarkDetails { get; set; }
        public string RemarkDate { get; set; }
        public string RemarkTime { get; set; }
        public string RemarkType { get; set; }
        public string RemarkSection { get; set; }
        public string ApprovalID { get; set; }

    }
}
