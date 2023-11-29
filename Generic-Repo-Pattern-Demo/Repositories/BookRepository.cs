using Generic_Repo_Pattern_Demo.Base;
using Generic_Repo_Pattern_Demo.Base.Interfaces;
using Generic_Repo_Pattern_Demo.Context;
using Generic_Repo_Pattern_Demo.Model;
using Microsoft.EntityFrameworkCore;

namespace Generic_Repo_Pattern_Demo.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public async Task<string> GetFirstBookName()
        {
            return await GetAll().Select(x => x.Name).FirstOrDefaultAsync();
        }
    }

    public interface IBookRepository : IRepository<Book>
    {
        Task<string> GetFirstBookName();
    }
}
