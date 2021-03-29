using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models.MSV
{
    [Keyless]
    public class PayerResponse
    {
        public DateTime? ResponseDateTime { get; set; }
        public string PayerReferenceNumber { get; set; }
        public string MsvPsvStatusID { get; set; }
        public string MsvPsvStatusCode { get; set; }
        public string MsvPsvStatusCodeParty { get; set; }
        public string MsvPsvStatusName { get; set; }
        public string MsvPsvStatusNameParty { get; set; }
        public string RemarkID { get; set; }
        public string RemarkCode { get; set; }
        public string RemarkCodeParty { get; set; }
        public string RemarkName { get; set; }
        public string RemarkNameParty { get; set; }
        public int MsvPsvID { get; set; }

    }
}
