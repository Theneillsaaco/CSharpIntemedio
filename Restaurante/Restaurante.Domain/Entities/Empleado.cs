using System.ComponentModel.DataAnnotations;

namespace Restaurante.Domain.Entities;

public partial class Empleado
{
    [Key]
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; }

    public string Cargo { get; set; }
}