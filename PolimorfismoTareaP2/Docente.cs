namespace PolimorfismoTareaP2;

    public abstract class Docente : Empleado
    {
        public string Tipo { get; set; } // porHora o contratoFijo

        public Docente(string nombre, int id, decimal salarioBase, string tipo) : base(nombre, id, salarioBase)
        {
            Tipo = tipo;
        }
    }