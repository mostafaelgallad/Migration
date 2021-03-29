using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class Editing
    {
        public string CanFollowUp { get; set; }
        public string CanCancel { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string ApprovalID { get; set; }

    }
}
