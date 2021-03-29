using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class Attachments
    {
        public int Index { get; set; }
        public string FileName { get; set; }
        public string FileTypeCode { get; set; }
        public string FileTypeName { get; set; }
        public string Comments { get; set; }
        public string AttachmentBinary { get; set; }
        public string AttachmentURL { get; set; }
        public string FilePath { get; set; }
        public string DocumentName { get; set; }
        public string Status { get; set; }
        public DateTime? RelatedToTransactionRequestDateTime { get; set; }
        public string RelatedToTransactionTypeID { get; set; }
        public string RelatedToTransactionTypeCode { get; set; }
        public string RelatedToTransactionTypeCodeParty { get; set; }
        public string RelatedToTransactionTypeName { get; set; }
        public string RelatedToTransactionTypeNameParty { get; set; }
        public string RelatedToApprovalID { get; set; }
        public string ApprovalID { get; set; }

    }
}
