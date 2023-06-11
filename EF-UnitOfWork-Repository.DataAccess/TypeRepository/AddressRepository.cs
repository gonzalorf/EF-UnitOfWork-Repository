using EF_UnitOfWork_Repository.Domain;
using EF_UnitOfWork_Repository.Domain.Interfaces;

namespace EF_UnitOfWork_Repository.DataAccess.TypeRepository;
class AddressRepository : Repository<Address>, IAddressRepository
{
    public AddressRepository(PersonContext context) : base(context) { }
}