using Microsoft.AspNetCore.Mvc;
using Project2.Data;
using Project2.Model;

namespace Project2.Service
{
    public class PersonService : IPersonService
    {
        private readonly ApplicationDbContext db;

        public PersonService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<Person> CreatePerson( Person p)
        {
            await db.personTables.AddAsync(p);
            await db.SaveChangesAsync();
            return p;
        }

        public async Task DeletePerson(Person p)
        {
            db.personTables.Remove(p);
            await db.SaveChangesAsync();  
        }
        public async Task<Person> GetPersonById(int? id)
        {    
             return db.personTables.Where(x => x.Id == id).SingleOrDefault();      
        }
        public IEnumerable<Person> GetPersonList()
        {
            return db.personTables.ToList();
        }

        public async Task UpdatePerson(Person p)
        {
            db.personTables.Update(p);
            await db.SaveChangesAsync();
        }
    }
}
