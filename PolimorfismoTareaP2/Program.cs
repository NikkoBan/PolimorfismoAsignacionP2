// Clase principal para ejecución

using PolimorfismoTareaP2;

class Program
{
    static void Main(string[] args)
    {
        var sistemaNominas = new SistemaNominas();

        sistemaNominas.AgregarEmpleado(new DocentePorHora("Juan Pérez", 1, 800m, 40));
        sistemaNominas.AgregarEmpleado(new DocenteContratoFijo("Ana Gómez", 2, 2000m, true));
        sistemaNominas.AgregarEmpleado(new Administrativo("Carlos López", 3, 1500m, 300m));

        sistemaNominas.MostrarEmpleados();
        Console.WriteLine($"Total de la nómina: {sistemaNominas.CalcularNomina():C}");
    }
}