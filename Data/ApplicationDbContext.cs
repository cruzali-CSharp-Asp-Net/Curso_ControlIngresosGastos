﻿using ControlIngresosGastos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ControlIngresosGastos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<IngresoGasto> IngresoGastos { get; set; }
    }
}
