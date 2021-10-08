using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Infra.Data.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            // TODO O DBCONTEXTOPTIONS É UMA MANEIRA DE CONFIGURAR E FAZER A PONTE DA SUA APLICÃÇÃO
            // COM O BANCO DE DADOS
            var optBuilder = new DbContextOptionsBuilder<AppDbContext>();
            // TODO tentar implementar o conceito de variável de ambiente,
            // https://medium.com/danielpadua/efcore-migrations-implementando-um-designtimedbcontextfactory-multi-ambiente-7f384d62cf2
            
            optBuilder.UseSqlServer("Server=ARKMF98769\\SQLEXPRESS;Database=Shop;Trusted_Connection=True;");
            

            return new AppDbContext(optBuilder.Options);

        }
    }
}
