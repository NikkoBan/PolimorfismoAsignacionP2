namespace PolimorfismoTareaP2;

    public abstract class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void MostrarNombre()
        {
            Console.WriteLine($"Nombre: {Nombre}");
        }
    }
