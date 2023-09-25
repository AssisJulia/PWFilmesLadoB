using Microsoft.EntityFrameworkCore;
using PWFilmes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWFilmes.API.Context
{
    public class PWFilmesContext: DbContext //esta classe vai trabalhar com o contexto do EntityFrameWork (herança)
    {
        public PWFilmesContext(DbContextOptions<PWFilmesContext> options) : base(options)
        {

        }

        public DbSet<Categoria> CategoriaSet { get; set; }
    }

}
