using System;
using ApiDaily.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApiDaily.Data.Concrete.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
}
