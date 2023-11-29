using Generic_Repo_Pattern_Demo.Base;
using Generic_Repo_Pattern_Demo.Context;
using Generic_Repo_Pattern_Demo.Model;
using Generic_Repo_Pattern_Demo.Repositories;

namespace Generic_Repo_Pattern_Demo.Controllers
{
    public class BookController : GenericController<Book>
    {
        public BookController(IBookRepository bookRepository) : base(bookRepository) { }

        //...
    }
}
