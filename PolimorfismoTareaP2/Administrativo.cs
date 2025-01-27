namespace PolimorfismoTareaP2;

    public class Administrativo : Empleado
    {
        public decimal Bonificacion { get; set; }

        public Administrativo(string nombre, int id, decimal salarioBase, decimal bonificacion)
            : base(nombre, id, salarioBase)
        {
            Bonificacion = bonificacion;
        }

        public override decimal CalcularSalario()
        {
            return SalarioBase + Bonificacion;
        }
    }
