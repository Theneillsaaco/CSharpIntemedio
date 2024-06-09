using AdminDepartament.Infrastucture.Context;
using AdminDepartament.Infrastucture.Core;
using AdminDepartamentos.Domain.Entities;
using AdminDepartamentos.Domain.Interfaces;
using AdminDepartamentos.Domain.Models;
using AdminDepartament.Infrastucture.Extentions;

namespace AdminDepartament.Infrastucture.Repositories;

/// <summary>
/// Clase Predeterminada de Pago; Y recupera la info de Inquilino(Es nesesario para funcionar).
/// </summary>
public class PagoRepository : BaseRepository<Pago>, IPagoRepository
{
    private readonly DepartContext _context;
    
    public PagoRepository(DepartContext context) : base(context)
    {
        this._context = context;
    }

    public List<PagoInquilinoModel> GetPago()
    {
        var pago = _context.Pagos
                .Where(co => co.Deleted == false)
                .Join(_context.Inquilinos,
                co => co.IdInquilino, inq => inq.IdInquilino,
                (co, inq) => co.ConvertPagoEntityToPagoInquilinoModel(inq))
                .ToList();

        return pago;
    }

    public List<PagoInquilinoModel> GetPagoByInquilino(int idInquilino)
    {
        var pago = _context.Pagos
                .Where(co => co.Deleted == false 
                         && co.IdInquilino == idInquilino)
                .Join(_context.Inquilinos, 
                co => co.IdInquilino, inq => inq.IdInquilino,
                (co, inq) => co.ConvertPagoEntityToPagoInquilinoModel(inq))
                .ToList();

        return pago;
    }
}