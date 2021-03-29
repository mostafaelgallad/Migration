using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSVHeader = MigrationTest.Models.MSV.Header;
namespace MigrationTest.Models
{
    public class MsvApprovalContext : DbContext
    {
        public MsvApprovalContext(DbContextOptions<MsvApprovalContext> options) : base(options)
        {

        }
        public DbSet<Header> Headers { get; set; }
        public DbSet<PayerResponse> PayerResponse { get; set; }
        public DbSet<PayerComment> PayerComment { get; set; }
        public DbSet<BeneficiaryDetails> BeneficiaryDetails { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<ServiceItem> ServiceItem { get; set; }
        public DbSet<TriageAssesments> TriageAssesments { get; set; }
        public DbSet<IllnessTypes> IllnessTypes { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<AdmissionDetails> AdmissionDetails { get; set; }
        public DbSet<DischargeDetails> DischargeDetails { get; set; }
        public DbSet<HealthyLifeStyleDetails> HealthyLifeStyleDetails { get; set; }
        public DbSet<HospitalCareDetails> HospitalCareDetails { get; set; }
        public DbSet<Attachments> Attachments { get; set; }
        public DbSet<ApprovalCancellationRemarks> ApprovalCancellationRemarks { get; set; }
        public DbSet<ApprovalReferralRemarks> ApprovalReferralRemarks { get; set; }
        public DbSet<TransactionMappingList> TransactionMappingList { get; set; }
        public DbSet<Editing> Editing { get; set; }
        public DbSet<ApprovalException> ApprovalException { get; set; }
        public DbSet<MigrationTest.Models.MSV.Header> MSVHeader { get; set; }
        public DbSet<MigrationTest.Models.MSV.PayerResponse> MSVPayerResponse { get; set; }
        public DbSet<MigrationTest.Models.MSV.BeneficiaryDetails> MSVBeneficiaryDetails { get; set; }
        public DbSet<MigrationTest.Models.MSV.TableOfBenefit> TableOfBenefit { get; set; }
   
    }
}
