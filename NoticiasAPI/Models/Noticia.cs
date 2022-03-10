using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NoticiasAPI.Models
{
   public class Noticia
    {
        public int NoticiaID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion  { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeEdicion { get; set; }
        public int AutorID { get; set; }
        public Autor Autor { get; set; }
        
        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Noticia> mepeoNoticia)
            {
                mepeoNoticia.HasKey(x => x.NoticiaID);
               mepeoNoticia.Property(x => x.Titulo).HasColumnName("Titulo");
                mepeoNoticia.ToTable("Noticia");
                mepeoNoticia.HasOne(x => x.Autor);
            }
        }
    }
}
