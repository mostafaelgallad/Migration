using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class IllnessTypes
    {
        public string IllnessTypeID { get; set; }
        public bool Checked { get; set; }
        public string IllnessTypeName { get; set; }
        public string When { get; set; }
        public string Where { get; set; }
        public string How { get; set; }
        public string ApprovalID { get; set; }

    }
}
