namespace PolimorfismoTareaP2;

    public class Profesor : Persona
    {
        public List<string> Cursos { get; set; }

        public Profesor(string nombre, List<string> cursos) : base(nombre)
        {
            Cursos = cursos;
        }

        public void ImpartirCurso()
        {
            Console.WriteLine($"El profesor {Nombre} está impartiendo un curso.");
        }
    }
