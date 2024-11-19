namespace HospitalManagamentSystem.Models
{
    public class Hypertension
    {
        public int SystolicPressure { get; set; } // Üst təzyiq (mmHg)
        public int DiastolicPressure { get; set; } // Alt təzyiq (mmHg)
        public string? Medication { get; set; } // Təyin olunan dərmanlar
        public double SodiumIntake { get; set; } // Natrium qəbul miqdarı (g)
        public string? ExercisePlan { get; set; } // İdman planı
    }
}
