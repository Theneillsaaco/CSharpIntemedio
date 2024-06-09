using AdminDepartamentos.Domain.Entities;
using AdminDepartamentos.Domain.Models;

namespace AdminDepartament.Infrastucture.Extentions;

public static class PagoExtentions
{
    /// <summary>
    ///  Metodo para convertir de la entida Pago y Inquilino a PagoInquilinoModel.
    /// </summary>
    /// <param name="pago">Pago.</param>
    /// <param name="inquilino">Inquilino.</param>
    /// <returns></returns>
    public static PagoInquilinoModel ConvertPagoEntityToPagoInquilinoModel(this Pago pago, Inquilino inquilino)
    {
        PagoInquilinoModel pagoInquilinoModel = new PagoInquilinoModel()
        {
            //Pago
            IdPago = pago.IdPago,
            FechaPago = pago.FechaPago,
            Monto = pago.Monto,
            Retrasado = pago.Retrasado,

            // Inquilino
            IdInquilino = pago.IdInquilino,
            InquilinoFirstName = inquilino.FirstName,
            InquilinoLastName = inquilino.LastName
        };

        return pagoInquilinoModel;
    }
}