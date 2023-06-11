using EF_UnitOfWork_Repository.DataAccess.TypeRepository;
using EF_UnitOfWork_Repository.Domain.Interfaces;

namespace EF_UnitOfWork_Repository.DataAccess.UnitOfWork;
public class UnitOfWork : IUnitOfWork
{
    private PersonContext context;
    public UnitOfWork(PersonContext context)
    {
        this.context = context;
        Address = new AddressRepository(this.context);
        Email = new EmailRepository(this.context);
        Person = new PersonRepository(this.context);
    }
    public IAddressRepository Address
    {
        get;
        private set;
    }
    public IEmailRepository Email
    {
        get;
        private set;
    }
    public IPersonRepository Person
    {
        get;
        private set;
    }
    public void Dispose()
    {
        context.Dispose();
    }
    public int Save()
    {
        return context.SaveChanges();
    }
}