namespace YarenSuYavuz2.Models
{
    public class EfRepository : IRepository
    {
        private DataContext context;
        public EfRepository(DataContext _context)
        {
            context = _context;

        }
    }
}
