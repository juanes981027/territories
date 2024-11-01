using System;
using FunctionApp4.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FunctionApp4.Infrastructure.Context;

public class AppDbContext : DbContext
{
    // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    // {
        
    // }
    // public DbSet<Person> Persons {get; set;}

}
