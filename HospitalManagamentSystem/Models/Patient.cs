namespace HospitalManagamentSystem.Models
{
    public class Patient
    {
        public int Id { get; set; } // Xəstənin unikal ID-si
        public string Name { get; set; } // Xəstənin adı
        public DateTime BirthDate { get; set; } // Doğum tarixi
        public string Gender { get; set; } // Cinsi (kişi/qadın)
        public List<Treatment> Treatments { get; set; } // Müalicələr siyahısı
    }

}
