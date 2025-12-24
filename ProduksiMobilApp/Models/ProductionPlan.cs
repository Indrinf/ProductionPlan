namespace ProduksiMobilApp.Models
{
    public class ProductionPlan
    {
        public int Id { get; set; }
        public int Senin { get; set; }
        public int Selasa { get; set; }
        public int Rabu { get; set; }
        public int Kamis { get; set; }
        public int Jumat { get; set; }
        public int Sabtu { get; set; }
        public int Minggu { get; set; }

        // Properti untuk menyimpan hasil perbaikan
        public int FixSenin { get; set; }
        public int FixSelasa { get; set; }
        public int FixRabu { get; set; }
        public int FixKamis { get; set; }
        public int FixJumat { get; set; }
        public int FixSabtu { get; set; }
        public int FixMinggu { get; set; }
    }
}
