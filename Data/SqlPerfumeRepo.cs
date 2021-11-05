using System.Collections.Generic;
using System.Linq;
using Perfume.Models;

namespace Perfume.Data
{
    public class SqlPerfumeRepo : IPerfumeRepo
    {
        //Injeção de dependência com o contexto do banco
        private readonly PerfumeContext _context;

        //Usando o construtor para a injeção de dependência
        public SqlPerfumeRepo(PerfumeContext context)
        {
            _context = context;
        }
        
        //Utilizando o contexto que eu tenho, trago todos os items como lista
        public IEnumerable<PerfumeModel> GetAllPerfumes()
        {
            return _context.Perfumes.ToList();
        }

        //Utilizando o contexto que eu tenho, trago o primeiro dos itens
        //pelo id encontrado e passado como parâmetro
        public PerfumeModel GetPerfumeById(int id)
        {
            return _context.Perfumes.FirstOrDefault(p => p.Id == id);
        }
    }
}