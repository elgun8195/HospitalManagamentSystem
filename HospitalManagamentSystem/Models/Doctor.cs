namespace HospitalManagamentSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; } // Həkimin unikal ID-si
        public string Name { get; set; } // Həkimin adı
        public string Specialization { get; set; } // İxtisası (kardioloq, nevroloq və s.)
        public List<Treatment> Treatments { get; set; } // Müalicələr siyahısı
    }

}
