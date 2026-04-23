using System.ComponentModel.DataAnnotations;

namespace SimuladorEnergiaWASM.Models
{
    public class PainelSolar
    {
        public int Id { get; set; }
        [Range(1, 100000)]
        public int Potencia { get; set; } = 550;
        public double Eficiencia { get; set; } = 80;
        [Range(0.0, 100.0)]
        public int Noct { get; set; } = 45;
        [Range(16.0, 40.0)]
        public double EficNominal { get; set; } = 21.5;
        [Range(0, 1)]
        public double Pmpp { get; set; } = 0.350; // Coeficiente de Temperatura do Pmpp/Perda por calor (valor em porcentagem)
        [Range(0.01, 1.0)]
        public double FatorSim { get; set; } = 0.350;
        public decimal TUSD { get; set; } = 0.55m; // muda conforme a quantidade de energia consumida no mês (100, 200, 400kWh, etc...)
        [Range(0.1, 1.0)]
        public double ProgressaoFioB { get; set; } = 0.60;
        [Range(0, double.MaxValue)]
        public decimal Custo { get; set; } = 1500m;
        [Required]
        [Range(1, 24)]
        public int HorasSol { get; set; } = 5;
        [Range(0, 50)]
        public int TempAmb { get; set; } = 20;
        [Range(0.01, 1.0)]
        public decimal TarifaEnergia { get; set; } = 0.38m;
        [Range(0, 200)]
        public int TaxaMinima { get; set; } = 30;
        public double CalculoKwh() => (Potencia * HorasSol * 30) / 1000.0;
    }
}
