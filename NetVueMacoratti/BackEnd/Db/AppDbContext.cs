using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Db
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<Aluno> Alunos { get; set; }


        // Cofere se a dados na tabela se não tiver ele os cria
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    AlunoId = 1,
                    Nome = "Maria da Penha",
                    Email = "mariaPenha@yahoo.com",
                    Idade = 23
                },
                new Aluno
                {

                    AlunoId = 2,
                    Nome = "Manuel Boeno",
                    Email = "manuelBoeno@yahoo.com",
                    Idade = 22
                }
            );
        }
    }
}