using System;
using Microsoft.EntityFrameworkCore;
using SistemaCRUD.Models;

namespace SistemaCRUD.Datos
{
    public class contextoBD:DbContext
    {
        public contextoBD(DbContextOptions<contextoBD> options):base(options)
        {

        }
        public DbSet<Cita> citas { get; set; }
    }
}
