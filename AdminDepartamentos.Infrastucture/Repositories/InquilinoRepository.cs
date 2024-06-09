using AdminDepartament.Infrastucture.Context;
using AdminDepartament.Infrastucture.Core;
using AdminDepartament.Infrastucture.Exceptions;
using AdminDepartament.Infrastucture.Extentions;
using AdminDepartamentos.Domain.Entities;
using AdminDepartamentos.Domain.Interfaces;
using AdminDepartamentos.Domain.Models;

namespace AdminDepartament.Infrastucture.Repositories;

/// <summary>
/// Clase Predeterminada de Inquilino; GetAll, Get, Save, ...
/// </summary>
public class InquilinoRepository : BaseRepository<Inquilino>, IInquilinoRepository
{
    private readonly DepartContext _context;

    public InquilinoRepository(DepartContext context) : base(context)
    {
        this._context = context;
    }
    
    public override async Task Save(Inquilino entity)
    {
        ArgumentNullException.ThrowIfNull(entity, "El Inquilino es Null.");
        
        if (entity is null)
            throw new ArgumentNullException("Inquilino es null, RELLENE TODOS LOS CAMPOS.");

        if (!await base.Exists(cd => cd.IdInquilino == entity.IdInquilino
                                              && cd.Cedula == entity.Cedula
                                              && cd.NumDepartamento == entity.NumDepartamento))
        {
            throw new InquilinoException("El Inquilino ya Existe.");
        }
    
        
        base.Save(entity);
    }
    
    public List<InquilinoModel> GetInquilinos()
    {
        var inquilino = _context.Inquilinos
            .Where(inq => inq.Deleted == false)
            .Select(inq => inq.ConvertInquilinoEntityToInquilinoModel())
            .ToList();

        return inquilino;
    }
}