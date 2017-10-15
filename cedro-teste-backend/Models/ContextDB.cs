using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ContextDB : DbContext
{
    private IConfigurationRoot _config;

    public ContextDB(IConfigurationRoot config, DbContextOptions<ContextDB> options) : base(options) 
    {
        _config = config;
    }

    public ContextDB() { }

    public DbSet<Restaurante> restaurante { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
    }
}
