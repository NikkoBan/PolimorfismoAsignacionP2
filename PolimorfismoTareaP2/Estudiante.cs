namespace PolimorfismoTareaP2;

    public class Estudiante : Persona
    {
        public string NumeroEstudiante { get; set; }

        public Estudiante(string nombre, string numeroEstudiante) : base(nombre)
        {
            NumeroEstudiante = numeroEstudiante;
        }

        public void AsistirClase()
        {
            Console.WriteLine($"El estudiante {Nombre} está asistiendo a clase.");
        }
    }
