using System.ComponentModel.DataAnnotations;

namespace PAB3
{
    public class Kody_Pocztowe
    {
        [Key]
        public string Kod_Pocztowy { get; set; }
        public string Adres { get; set; }
        public string Miejscowosc { get; set; }
        public string Wojewodztwo { get; set; }
        public string Powiat { get; set; }
    }
}