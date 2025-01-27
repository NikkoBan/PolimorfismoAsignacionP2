namespace PolimorfismoTareaP2;

    public class DocentePorHora : Docente
    {
        public int HorasTrabajadas { get; set; }
        public decimal TarifaHora { get; set; }

        public DocentePorHora(string nombre, int id, decimal tarifaHora, int horasTrabajadas)
            : base(nombre, id, 0, "porHora")
        {
            TarifaHora = tarifaHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularSalario()
        {
            return HorasTrabajadas * TarifaHora;
        }
    }
