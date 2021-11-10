using System.Collections.Generic;
using Perfume.Models;

namespace Perfume.Data
{
    public interface IPerfumeRepo
    {
        bool SaveChanges();
        IEnumerable<PerfumeModel> GetAllPerfumes();
        PerfumeModel GetPerfumeById(int id);
        void CreatePerfume(PerfumeModel perfume);
        void UpdatePerfume(PerfumeModel perfume);
    }
}