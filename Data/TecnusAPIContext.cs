using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TecnusAPI.Model;
namespace TecnusAPI.Data
{
    public class TecnusAPIContext : IdentityDbContext
    {
        public TecnusAPIContext(DbContextOptions<TecnusAPIContext> options) : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Curso>().ToTable("Cursos");
            modelBuilder.Entity<Video>().ToTable("Videos");
            modelBuilder.Entity<Quiz>().ToTable("Quizzes");
            modelBuilder.Entity<Pergunta>().ToTable("Perguntas");
            modelBuilder.Entity<Comentario>().ToTable("Comentarios");
        }
    }
}
