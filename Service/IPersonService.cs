using Project2.Model;

namespace Project2.Service
{
    public interface IPersonService
    {
        IEnumerable<Person> GetPersonList();
         Task<Person> GetPersonById(int? id);

        Task<Person> CreatePerson(Person p);

        Task UpdatePerson(Person p);
        Task DeletePerson(Person p);
    }
}
