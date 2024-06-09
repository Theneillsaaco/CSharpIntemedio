using AdminDepartamentos.Domain.Entities;
using AdminDepartamentos.Domain.Models;

namespace AdminDepartament.Infrastucture.Extentions;

public static class InquilinoExtentions
{
    public static InquilinoModel ConvertInquilinoEntityToInquilinoModel(this Inquilino inquilino)
    {
        InquilinoModel inquilinoModel = new InquilinoModel()
        {
            IdInquilino = inquilino.IdInquilino,
            FirstName = inquilino.FirstName,
            LastName = inquilino.LastName,
            Cedula = inquilino.Cedula,
            NumDepartamento = inquilino.NumDepartamento,
            NumTelefono = inquilino.NumTelefono,
            CreationDate = inquilino.CreationDate
        };

        return inquilinoModel;
    }
}