

namespace YarenSuYavuz2.Models { 
public interface ISatissRepository
{
    Satiss GetById(int id);
    IEnumerable<Satiss> GetSatiss();
    IEnumerable<Satiss> GetSatissByActive(bool isactive);

    void CreateSipariss(Satiss newSatiss);
    void UpdateSipariss(Satiss updatedSatiss);
    void DeleteSipariss(int Satissid);
}
}

