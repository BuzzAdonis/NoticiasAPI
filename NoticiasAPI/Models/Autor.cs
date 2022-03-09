using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasAPI.Models
{
    class Autor
    {
        public int NoticiaID { get; set; }
        public int AutorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeEdicion { get; set; }
      public class Mapeo {
        public Mapeo(EntityTypeBuilder<Autor> mepeoNoticia)
        {
            mepeoNoticia.HasKey(x => x.AutorID);
        }
    } }
}
