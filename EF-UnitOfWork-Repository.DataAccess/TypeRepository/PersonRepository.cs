using EF_UnitOfWork_Repository.Domain;
using EF_UnitOfWork_Repository.Domain.Interfaces;

namespace EF_UnitOfWork_Repository.DataAccess.TypeRepository;
class PersonRepository : Repository<Person>, IPersonRepository
{
    public PersonRepository(PersonContext context) : base(context) { }
}