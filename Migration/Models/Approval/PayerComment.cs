using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class PayerComment
    {
        public DateTime? CommentDate { get; set; }
        public string CommentText { get; set; }
        public string ApprovalID { get; set; }
    }
}
