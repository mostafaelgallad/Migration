using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Models
{
    [Keyless]
    public class TriageAssesments
    {
        public string ChiefComplaint { get; set; }
        public string SignificantSigns { get; set; }
        public string OtherConditions { get; set; }
        public string TriageCategoryID { get; set; }
        public string TriageCategoryCode { get; set; }
        public string TriageCategoryCodeParty { get; set; }
        public string TriageCategoryName { get; set; }
        public string TriageCategoryNameParty { get; set; }
        public DateTime TriageDate { get; set; }
        public string TriageTime { get; set; }
        public int OpticalVitalSignPrescriptionTestID { get; set; }
        public string OpticalVitalSignPrescriptionTestName { get; set; }
        public int OpticalVitalSignProviderID { get; set; }
        public string OpticalVitalSignProviderName { get; set; }
        public string OpticalVitalSignPhysicianName { get; set; }
        public string OpticalVitalSignPhysicianLicenseNo { get; set; }
        public string OpticalVitalSignVisitPurposeID { get; set; }
        public string OpticalVitalSignVisitPurposeName { get; set; }
        public string OpticalVitalSignRegularLenseID { get; set; }
        public string OpticalVitalSignRegularLenseName { get; set; }
        public string OpticalVitalSignContactLenseID { get; set; }
        public string OpticalVitalSignContactLenseName { get; set; }
        public string OpticalVitalSignLeftEYESPHDistance { get; set; }
        public string OpticalVitalSignLeftEYECYLDistance { get; set; }
        public string OpticalVitalSignLeftEYEAxisDistance { get; set; }
        public string OpticalVitalSignLeftEYEPrismDistance { get; set; }
        public string OpticalVitalSignLeftEYEPDDistance { get; set; }
        public string OpticalVitalSignLeftEYEAddDistance { get; set; }
        public string OpticalVitalSignLeftEYESPHNear { get; set; }
        public string OpticalVitalSignLeftEYECYLNear { get; set; }
        public string OpticalVitalSignLeftEYEAxisNear { get; set; }
        public string OpticalVitalSignLeftEYEPrismNear { get; set; }
        public string OpticalVitalSignLeftEYEPDNear { get; set; }
        public string OpticalVitalSignLeftEYEAddNear { get; set; }
        public string OpticalVitalSignLeftEYEVertext { get; set; }
        public string OpticalVitalSignLeftEYEBiofacl { get; set; }
        public string OpticalVitalSignRightEyeSPHDistance { get; set; }
        public string OpticalVitalSignRightEyeCYLDistance { get; set; }
        public string OpticalVitalSignRightEyeAxisDistance { get; set; }
        public string OpticalVitalSignRightEyePrismDistance { get; set; }
        public string OpticalVitalSignRightEyePDDistance { get; set; }
        public string OpticalVitalSignRightEyeAddDistance { get; set; }
        public string OpticalVitalSignRightEyeSPHNear { get; set; }
        public string OpticalVitalSignRightEyeCYLNear { get; set; }
        public string OpticalVitalSignRightEyeAxisNear { get; set; }
        public string OpticalVitalSignRightEyePrismNear { get; set; }
        public string OpticalVitalSignRightEyePDNear { get; set; }
        public string OpticalVitalSignRightEyeAddNear { get; set; }
        public string OpticalVitalSignRightEyeVertext { get; set; }
        public string OpticalVitalSignRightEyeBiofacl { get; set; }
        public string VitalSignTemperature { get; set; }
        public string VitalSignSystolicBloodPressure { get; set; }
        public string VitalSignDiastolicBloodPressure { get; set; }
        public string VitalSignPulse { get; set; }
        public string VitalSignRespiratoryRate { get; set; }
        public string VitalSignWeight { get; set; }
        public string VitalSignHeight { get; set; }
        public string VitalSignDeliveryTypeID { get; set; }
        public string VitalSignDeliveryTypeCode { get; set; }
        public string VitalSignDeliveryTypeCodeParty { get; set; }
        public string VitalSignDeliveryTypeName { get; set; }
        public string VitalSignDeliveryTypeNameParty { get; set; }
        public DateTime? VitalSignLMPDate { get; set; }
        public string VitalSignHeartRhythmType { get; set; }
        public string VitalSignArrivalMode { get; set; }
        public int? VitalSignWaitingTime { get; set; }
        public string VitalSignDispositionCode { get; set; }
        public DateTime? VitalSignLastMenstruationPeriodDate { get; set; }
        public string VitalSignIllnessDuration { get; set; }
        public string VitalSignIllnessDurationUnitCode { get; set; }
        public string VitalSignIllnessUnitID { get; set; }
        public string VitalSignIllnessUnitCode { get; set; }
        public string VitalSignIllnessUnitCodeParty { get; set; }
        public string VitalSignIllnessUnitName { get; set; }
        public string VitalSignIllnessUnitNameParty { get; set; }
        public string ApprovalID { get; set; }

    }
}
