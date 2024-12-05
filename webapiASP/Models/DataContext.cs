using Microsoft.EntityFrameworkCore;

namespace webapiASP.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options){}
    public DbSet<Prices> Prices => Set<Prices>();
    public DbSet<RegistrationProduct> RegistrationProduct => Set<RegistrationProduct>();
    public DbSet<Persons> Users => Set<Persons>();
}