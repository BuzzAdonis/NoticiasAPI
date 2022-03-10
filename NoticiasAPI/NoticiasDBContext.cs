using Microsoft.EntityFrameworkCore;
using NoticiasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasAPI
{
  public  class NoticiasDBContext: DbContext
    {
        public NoticiasDBContext(DbContextOptions opsiones) : base(opsiones)
        {

        }
        public DbSet<Noticia> Noticia { get; set; }
        public DbSet<Autor> Autor { get; set; }
        protected override void OnModelCreating(ModelBuilder crearModelo)
        {
            new Noticia.Mapeo(crearModelo.Entity<Noticia>());
            new Autor.Mapeo(crearModelo.Entity<Autor>());

        }
    }
}
