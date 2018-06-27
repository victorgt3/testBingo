using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestBingo.Models;

namespace TestBingo.Context
{
    public class BingoContext : DbContext
    {
        //representa a tabela no banco de dados
        public DbSet<Cartela> Cartela { get; set; }

        public DbSet<Sorteio> Sorteio { get; set; }
    }
}