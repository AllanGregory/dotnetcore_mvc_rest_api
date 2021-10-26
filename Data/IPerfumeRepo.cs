using System.Collections.Generic;
using Perfume.Models;

namespace Perfume.Data
{
    public interface IPerfumeRepo
    {
        IEnumerable<PerfumeModel> GetAllPerfumes();
        PerfumeModel GetPerfumeById(int id);
    }
}