using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTest.Migrations
{
    public partial class IntialMigratin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdmissionDetails",
                columns: table => new
                {
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdmissionTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionTypeCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionTypeNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtendedWaitPatientID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedLengthOfStay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedLengthOfStayUnitID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedLengthOfStayUnitCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedLengthOfStayUnitCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedLengthOfStayUnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedLengthOfStayUnitNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmbulatoryCareInformationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalCauseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduledAdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClinicalComplexityID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EncounterTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ApprovalCancellationRemarks",
                columns: table => new
                {
                    RemarkDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ApprovalException",
                columns: table => new
                {
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ApprovalReferralRemarks",
                columns: table => new
                {
                    RemarkDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Index = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentBinary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedToTransactionRequestDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RelatedToTransactionTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedToTransactionTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedToTransactionTypeCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedToTransactionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedToTransactionTypeNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedToApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BeneficiaryDetails",
                columns: table => new
                {
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeUnitID = table.Column<int>(type: "int", nullable: false),
                    AgeUnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalityID = table.Column<int>(type: "int", nullable: false),
                    NationalityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityTypeID = table.Column<byte>(type: "tinyint", nullable: true),
                    MemberType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipMemberClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipBeneficiaryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipInceptionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MembershipEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MembershipPolicyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipPolicyHolderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipPlanType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipMRN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    DiagnosisCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosisDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosisDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiagnosisTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosisTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosisOnSetFlagID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosisOnSetFlagCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosisOnSetFlagName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MDBID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MDBName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MDCID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MDCName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DRGName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DRGCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsUnacceptPrimaryDiagnosis = table.Column<bool>(type: "bit", nullable: false),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DischargeDetails",
                columns: table => new
                {
                    DischargeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DischargeTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeModeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Editing",
                columns: table => new
                {
                    CanFollowUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CanCancel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Headers",
                columns: table => new
                {
                    PayerID = table.Column<int>(type: "int", nullable: false),
                    PayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayerIsTPA = table.Column<bool>(type: "bit", nullable: false),
                    PayerLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TPAPayerID = table.Column<int>(type: "int", nullable: false),
                    TPAPayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TPAIsTPA = table.Column<bool>(type: "bit", nullable: false),
                    TPAPayerLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderID = table.Column<int>(type: "int", nullable: false),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderCodePayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderCategoryID = table.Column<int>(type: "int", nullable: false),
                    ProviderLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionRequestDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransactionTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionTypeCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionTypeNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalProcessorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChannelID = table.Column<int>(type: "int", nullable: false),
                    CorrelationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentApprovalID = table.Column<long>(type: "bigint", nullable: true),
                    ApprovalTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalTypeCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalTypeNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicianID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicianCategoryID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicianCategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicianCategoryCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicianCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicianCategoryNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicianSCFHS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecialityID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecialityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecialityCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecialityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecialityNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitTypeCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitTypeNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferalNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FollowUpNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UILayout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInPatient = table.Column<bool>(type: "bit", nullable: false),
                    IsFromReferal = table.Column<bool>(type: "bit", nullable: false),
                    IsMSVPSVRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsLatest = table.Column<bool>(type: "bit", nullable: false),
                    IsParent = table.Column<bool>(type: "bit", nullable: false),
                    ApprovalInquiryAllow = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    MsvPsvID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HealthyLifeStyleDetails",
                columns: table => new
                {
                    PhysicalActivityID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DietTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SportTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TabacoSmokingStatusID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmokingConsumptionID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergyHistoryID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    referalOfAbuseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EposideOfTreatmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PastMedicalHistoryID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VascularProcedureID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationOfImairmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubstanceAbuseHistoryID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfCommencement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfCommencement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HospitalCareDetails",
                columns: table => new
                {
                    IntendedStayLengthID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedStayLenthInDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterhospitalContractedPatientID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationTreatmentTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOLeavePeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedLengthOfStay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "IllnessTypes",
                columns: table => new
                {
                    IllnessTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Checked = table.Column<bool>(type: "bit", nullable: false),
                    IllnessTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    When = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Where = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    How = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MSVBeneficiaryDetails",
                columns: table => new
                {
                    IdentityTypeID = table.Column<byte>(type: "tinyint", nullable: true),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NationalityID = table.Column<int>(type: "int", nullable: false),
                    NationalityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipMemberClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipInceptionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MembershipEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MembershipPolicyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipPolicyHolderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipPlanType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsvPsvID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MSVHeader",
                columns: table => new
                {
                    PayerID = table.Column<int>(type: "int", nullable: false),
                    PayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayerIsTPA = table.Column<bool>(type: "bit", nullable: false),
                    PayerLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TPAPayerID = table.Column<int>(type: "int", nullable: false),
                    TPAPayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TPAIsTPA = table.Column<bool>(type: "bit", nullable: false),
                    TPAPayerLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderID = table.Column<int>(type: "int", nullable: false),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderCodePayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderCategoryID = table.Column<int>(type: "int", nullable: false),
                    ProviderLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionRequestDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChannelID = table.Column<int>(type: "int", nullable: false),
                    CorrelationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsvPsvID = table.Column<int>(type: "int", nullable: false),
                    MSVExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MsvTypeID = table.Column<int>(type: "int", nullable: false),
                    MsvTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialityNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecialityID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecialityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecialityCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecialityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecialityNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BenfitTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BenfitTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BenfitTypeCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BenfitTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BenfitTypeNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MSVPayerResponse",
                columns: table => new
                {
                    ResponseDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PayerReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsvPsvStatusID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsvPsvStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsvPsvStatusCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsvPsvStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsvPsvStatusNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsvPsvID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PayerComment",
                columns: table => new
                {
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PayerResponse",
                columns: table => new
                {
                    ResponseDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PayerReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalStatusID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalStatusCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalStatusNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalValidityPeriodDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalValidityPeriodUnitCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedLengthOfStaySummaryDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedLengthOfStaySummaryUnitCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkCommentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemarkCommentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ServiceItem",
                columns: table => new
                {
                    RelatedToTransactionTypeCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedToTransactionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedToTransactionTypeNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedToApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceDecisionsApprovedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceDecisionsApprovedCostCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedCostAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PayerServiceCommentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PayerServiceCommentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceStatusID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceStatusCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceStatusNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    TotalRequestedCostCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalRequestedCostAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalApprovedCostCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalApprovedCostAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReferralReasonID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferralReasonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferralModeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferralModeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferralModeOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TableOfBenefit",
                columns: table => new
                {
                    MaxPhysicianFee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreAuthorizationLimit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deductible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MPNDeductible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OHNDeductible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OCNDeductible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Copayment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreatmentExpenses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeductibleTobeCollected = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduleOfBenefit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsvPsvID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TransactionMappingList",
                columns: table => new
                {
                    TransactionTypeID = table.Column<int>(type: "int", nullable: false),
                    TransactionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiresIn = table.Column<int>(type: "int", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TriageAssesments",
                columns: table => new
                {
                    ChiefComplaint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignificantSigns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TriageCategoryID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TriageCategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TriageCategoryCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TriageCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TriageCategoryNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TriageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TriageTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignPrescriptionTestID = table.Column<int>(type: "int", nullable: false),
                    OpticalVitalSignPrescriptionTestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignProviderID = table.Column<int>(type: "int", nullable: false),
                    OpticalVitalSignProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignPhysicianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignPhysicianLicenseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignVisitPurposeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignVisitPurposeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRegularLenseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRegularLenseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignContactLenseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignContactLenseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYESPHDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYECYLDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYEAxisDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYEPrismDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYEPDDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYEAddDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYESPHNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYECYLNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYEAxisNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYEPrismNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYEPDNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYEAddNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYEVertext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignLeftEYEBiofacl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyeSPHDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyeCYLDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyeAxisDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyePrismDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyePDDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyeAddDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyeSPHNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyeCYLNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyeAxisNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyePrismNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyePDNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyeAddNear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyeVertext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpticalVitalSignRightEyeBiofacl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignTemperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignSystolicBloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignDiastolicBloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignPulse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignRespiratoryRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignDeliveryTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignDeliveryTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignDeliveryTypeCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignDeliveryTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignDeliveryTypeNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignLMPDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VitalSignHeartRhythmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignArrivalMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignWaitingTime = table.Column<int>(type: "int", nullable: true),
                    VitalSignDispositionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignLastMenstruationPeriodDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VitalSignIllnessDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignIllnessDurationUnitCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignIllnessUnitID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignIllnessUnitCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignIllnessUnitCodeParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignIllnessUnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitalSignIllnessUnitNameParty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionDetails");

            migrationBuilder.DropTable(
                name: "ApprovalCancellationRemarks");

            migrationBuilder.DropTable(
                name: "ApprovalException");

            migrationBuilder.DropTable(
                name: "ApprovalReferralRemarks");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "BeneficiaryDetails");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "DischargeDetails");

            migrationBuilder.DropTable(
                name: "Editing");

            migrationBuilder.DropTable(
                name: "Headers");

            migrationBuilder.DropTable(
                name: "HealthyLifeStyleDetails");

            migrationBuilder.DropTable(
                name: "HospitalCareDetails");

            migrationBuilder.DropTable(
                name: "IllnessTypes");

            migrationBuilder.DropTable(
                name: "MSVBeneficiaryDetails");

            migrationBuilder.DropTable(
                name: "MSVHeader");

            migrationBuilder.DropTable(
                name: "MSVPayerResponse");

            migrationBuilder.DropTable(
                name: "PayerComment");

            migrationBuilder.DropTable(
                name: "PayerResponse");

            migrationBuilder.DropTable(
                name: "ServiceItem");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "TableOfBenefit");

            migrationBuilder.DropTable(
                name: "TransactionMappingList");

            migrationBuilder.DropTable(
                name: "TriageAssesments");
        }
    }
}
