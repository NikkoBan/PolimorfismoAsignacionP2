namespace PolimorfismoTareaP2;

    public class DocenteContratoFijo : Docente
    {
        public bool MetaCumplida { get; set; }

        public DocenteContratoFijo(string nombre, int id, decimal salarioBase, bool metaCumplida)
            : base(nombre, id, salarioBase, "contratoFijo")
        {
            MetaCumplida = metaCumplida;
        }

        public override decimal CalcularSalario()
        {
            return MetaCumplida ? SalarioBase : SalarioBase / 2;
        }
    }
