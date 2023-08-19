using CalculoCDBWebAPI.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCDBWebAPI.Application.Interfaces
{
    public interface IApplicationServiceTaxa
    {
        void Add(TaxaDTO obj);

        TaxaDTO GetById(int id);

        IEnumerable<TaxaDTO> GetAll();

        void Update(TaxaDTO obj);

        void Remove(TaxaDTO obj);

        void Dispose();
    }
}
