namespace Course.Services
{
    public class StudentService
    {
        private readonly  dbContext;

        public BookService(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
