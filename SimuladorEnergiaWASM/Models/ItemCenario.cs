using System.ComponentModel.DataAnnotations;
namespace SimuladorEnergiaWASM.Models

{
    public class ItemCenario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        [Range(1, 50000)]
        public double Consumo { get; set; }
        [Required]
        [Range(0.01, 24)]
        public double HorasUso { get; set; }
        [Range(1, 1000)]
        public int Quantidade { get; set; } = 1;

        public double CalculoKwh() => (Consumo * HorasUso * 30) / 1000.0;
    }
}
