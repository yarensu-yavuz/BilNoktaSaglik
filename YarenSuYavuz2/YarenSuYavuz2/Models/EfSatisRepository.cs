using static YarenSuYavuz2.Models.EfSatisRepository;

namespace YarenSuYavuz2.Models
{

    public class EfSatisRepository : ISatissRepository
    {
        private DataContext context;
        public EfSatisRepository(DataContext _context)

        {

            context = _context;
        }

        public void CreateSatiss(Satiss newSatis)
        {
            throw new NotImplementedException();
        }

        public void DeleteSatiss(int satisid)
        {
            throw new NotImplementedException();
        }

        public Satiss GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Satiss> GetSatissByActive(bool isactive)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Satiss> GetSatiss()
        {
            throw new NotImplementedException();
        }
        
        public void UpdateSatiss(Satiss updatedSipariss)
        {
            throw new NotImplementedException();
        }
    }
}

