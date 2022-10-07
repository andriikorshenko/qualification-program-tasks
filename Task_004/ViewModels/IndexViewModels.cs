using Task_004.Models;

namespace Task_004.ViewModels
{
    public class IndexViewModels
    {
        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
