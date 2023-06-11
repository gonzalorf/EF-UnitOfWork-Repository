using EF_UnitOfWork_Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace EF_UnitOfWork_Repository.DataAccess;

public class PersonContext: DbContext {
    public PersonContext(DbContextOptions options): base(options) {}
    public DbSet <Person> Person {
        get;
        set;
    }
    public DbSet <Address> Address {
        get;
        set;
    }
    public DbSet <Email> Email {
        get;
        set;
    }
}