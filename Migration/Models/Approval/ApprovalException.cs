using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class ApprovalException
    {
        public string ErrorMessage { get; set; }
        public string ApprovalID { get; set; }

    }
}
