namespace PolimorfismoTareaP2;

public class SistemaNominas
{
    public List<Empleado> Empleados { get; set; } = new List<Empleado>();

    public void AgregarEmpleado(Empleado empleado)
    {
        Empleados.Add(empleado);
    }

    public void MostrarEmpleados()
    {
        foreach (var empleado in Empleados)
        {
            empleado.MostrarNombre();
            Console.WriteLine($"Salario calculado: {empleado.CalcularSalario():C}");
        }
    }

    public decimal CalcularNomina()
    {
        decimal total = 0;
        foreach (var empleado in Empleados)
        {
            total += empleado.CalcularSalario();
        }
        return total;
    }
}