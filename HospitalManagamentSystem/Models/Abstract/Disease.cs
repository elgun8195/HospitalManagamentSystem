namespace HospitalManagamentSystem.Models.Abstract
{
    public class Disease
    {
        public int Id { get; set; } // Xəstəliyin unikal ID-si
        public int PatientId { get; set; } // Xəstənin ID-si
        public DateTime DiagnosisDate { get; set; } // Diaqnoz tarixi
        public string? DoctorNotes { get; set; } // Həkimin qeydləri
    }
}
