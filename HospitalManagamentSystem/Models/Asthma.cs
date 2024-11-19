namespace HospitalManagamentSystem.Models
{
    public class Asthma
    {
        public string? TriggerFactors { get; set; } // Tətikləyici amillər (toz, polen və s.)
        public int PeakFlowRate { get; set; } // Tənəffüs sürəti (L/min)
        public string? InhalerType { get; set; } // İnhalyator növü
        public int InhalerUsagePerDay { get; set; } // Gündəlik istifadəsi (dəfə)
        public bool IsEmergencyVisit { get; set; } // Təcili yardım tələb edilibmi?
    }
}
