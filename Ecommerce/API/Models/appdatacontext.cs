using System;
using Microsoft.EntityFrameworkCore;

namespace API.Models;


public class AppDataContext : DbContext
{
    // primeira tabela
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categoria { get; set; }


     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Ecommerce.db");
    }


}