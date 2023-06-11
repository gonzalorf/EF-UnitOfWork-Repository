using EF_UnitOfWork_Repository.Domain;
using EF_UnitOfWork_Repository.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EF_UnitOfWork_Repository;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly IUnitOfWork unitOfWork;
    public PersonController(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }
    [HttpGet]
    [Route("[action]")]
    public IEnumerable<Person> GetAllPersons()
    {
        return unitOfWork.Person.GetAll();
    }

    [HttpPost]
    [Route("[action]")]
    public Person NewPerson([FromBody]Person person)
    {
        unitOfWork.Person.Add(person);
        return unitOfWork.Person.GetById(person.PersonId);
    }
}