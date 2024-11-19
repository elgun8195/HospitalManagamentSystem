namespace HospitalManagamentSystem.Models
{
    public class Treatment
    {
        public int Id { get; set; } // Müalicənin unikal ID-si
        public int PatientId { get; set; } // Müalicə olunan xəstənin ID-si
        public Patient Patient { get; set; } // Xəstə obyekti
        public int DoctorId { get; set; } // Müalicəni həyata keçirən həkimin ID-si
        public Doctor Doctor { get; set; } // Həkim obyekti
        public DateTime TreatmentDate { get; set; } // Müalicənin tarixi
        public string? Diagnosis { get; set; } // Diaqnoz
        public string? PrescribedMedication { get; set; } // Təyin olunmuş dərmanlar
    }

}
