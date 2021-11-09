using System.Collections.Generic;
using Perfume.Models;

namespace Perfume.Data
{
    //Repositório apenas para retornar dados mockados
    public class MockPerfumeRepo : IPerfumeRepo
    {
        public void CreatePerfume(PerfumeModel perfume)
        {
            throw new System.NotImplementedException();
        }

        //Método que retorna uma lista do tipo PerfumeModel
        public IEnumerable<PerfumeModel> GetAllPerfumes()
        {
            var perfumes = new List<PerfumeModel>
            {
                new PerfumeModel{
                    Id = 0,
                    Nome = "212 NYC MEN",
                    Valor = 270.90,
                    Estacao = "Verão",
                    Projecao = "Média",
                    Longevidade = "Alta"
                },
                new PerfumeModel{
                    Id = 1,
                    Nome = "Savage",
                    Valor = 700,
                    Estacao = "Todas",
                    Projecao = "Alta",
                    Longevidade = "Alta"
                },
                new PerfumeModel{
                    Id = 2,
                    Nome = "Bleu",
                    Valor = 1200.80,
                    Estacao = "Todas",
                    Projecao = "Alta",
                    Longevidade = "Alta"
                }
            };

            return perfumes;
        }

        //Método que retorna um objeto do tipo PerfumeModel
        public PerfumeModel GetPerfumeById(int id)
        {
            return new PerfumeModel{
                Id = 0,
                Nome = "212 NYC MEN",
                Valor = 270.90,
                Estacao = "Verão",
                Projecao = "Média",
                Longevidade = "Alta"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}