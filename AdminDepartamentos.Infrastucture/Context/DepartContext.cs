﻿using AdminDepartamentos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminDepartament.Infrastucture.Context
{
    public partial class DepartContext : DbContext
    {
        
        public DepartContext (DbContextOptions <DepartContext> options) : base(options) { }

        #region "Entities"

        public DbSet <Inquilino> Inquilinos { get; set; }
        public DbSet <Pago> Pagos { get; set; }

        #endregion
    }
}
