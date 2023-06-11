using EF_UnitOfWork_Repository.Domain;
using EF_UnitOfWork_Repository.Domain.Interfaces;

namespace EF_UnitOfWork_Repository.DataAccess.TypeRepository;
class EmailRepository : Repository<Email>, IEmailRepository
{
    public EmailRepository(PersonContext context) : base(context) { }
}