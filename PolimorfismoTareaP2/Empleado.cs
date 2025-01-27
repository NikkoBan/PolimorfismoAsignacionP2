namespace PolimorfismoTareaP2;
    public abstract class Empleado : Persona
    {
        public int Id { get; set; }
        public decimal SalarioBase { get; set; }

        public Empleado(string nombre, int id, decimal salarioBase) : base(nombre)
        {
            Id = id;
            SalarioBase = salarioBase;
        }

        public abstract decimal CalcularSalario();
    }
