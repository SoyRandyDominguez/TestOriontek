using Abp.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOriontec.People;

namespace TestOriontec.EntityFramework.Repositories
{
    public class PeopleRepository : TestOriontecRepositoryBase<Person>, IPersonRepository
    {

        public PeopleRepository(IDbContextProvider<TestOriontecDbContext> dbContextProvider)
                : base(dbContextProvider)
        {
        }
        public List<Person> GetAllWithName(string personName)
        {
            //In repository methods, we do not deal with create/dispose DB connections, DbContexes and transactions. ABP handles it.

            var query = GetAll(); //GetAll() returns IQueryable<T>, so we can query over it.
                                  //var query = Context.Tasks.AsQueryable(); //Alternatively, we can directly use EF's DbContext object.
                                  //var query = Table.AsQueryable(); //Another alternative: We can directly use 'Table' property instead of 'Context.Tasks', they are identical.

            //Add some Where conditions...

            if (personName.Length >= 0)
            {
                query = query.Where(person => person.Name.Contains(personName));
            }
             

            return query
                .OrderByDescending(person => person.Id)
                .ToList();
        }

        public Person GetOneById(int id)
        {
            var query = GetAll().FirstOrDefault(x => x.Id == id);

            return query;
        }
    }
}
