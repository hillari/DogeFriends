using System;
using Microsoft.EntityFrameworkCore;

namespace API;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}
