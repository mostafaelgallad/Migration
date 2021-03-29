using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class TransactionMappingList
    {
        public int TransactionTypeID { get; set; }
        public string TransactionTypeName { get; set; }
        public int ExpiresIn { get; set; }
        public bool IsExpired { get; set; }
        public string ApprovalID { get; set; }

    }
}
