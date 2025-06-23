using Microsoft.EntityFrameworkCore;

namespace LINQ_TO_ENTITIES.Model
{
    public class EscolaContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite(@"Data Source=..\escola.db");
    }
}