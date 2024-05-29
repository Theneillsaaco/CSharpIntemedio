using Restaurante.Domain.Core.EntityBase;
using System.ComponentModel.DataAnnotations;

namespace Restaurante.Domain.Entities;

public partial class Cliente : Person
{
    [Key]
    public int IdCliente { get; set; }

    public string Telefono { get; set; }

    public string Email { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}