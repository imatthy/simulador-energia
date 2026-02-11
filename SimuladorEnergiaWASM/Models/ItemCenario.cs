using System.ComponentModel.DataAnnotations;
namespace SimuladorEnergiaWASM.Models

{
    public class ItemCenario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        [Range(1, 50000)]
        public float Consumo { get; set; }
        [Required]
        [Range(0.01, 24)]
        public float HorasUso { get; set; }
        public float Tarifa = 0.73f;

        public double CalculoKwh()
        {
            return (Consumo * HorasUso * 30) / 1000.0;
        }
        public double CalculoCusto()
        {
            return Math.Round(CalculoKwh() * Tarifa, 3);
        }
    }
}
