using TickTick.Api.Dtos.Persons;
using TickTick.Models.Dtos;

namespace TickTick.Api.Services
{
    public interface IPersonsService
    {
        void DeletePerson(Guid id);
        PersonDto AddPerson(AddPersonDto dto);
        PersonDto UpdatePerson(Guid personId, PersonDto dto);
    }
}