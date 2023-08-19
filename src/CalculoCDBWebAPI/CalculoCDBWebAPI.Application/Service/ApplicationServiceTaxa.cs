using CalculoCDBWebAPI.Application.DTO.DTO;
using CalculoCDBWebAPI.Application.Interfaces;
using CalculoCDBWebAPI.Domain.Core.Interfaces.Services;
using CalculoCDBWebAPI.Infrastructure.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCDBWebAPI.Application.Service
{
    public class ApplicationServiceTaxa : IApplicationServiceTaxa
    {
        private readonly IServiceTaxa _service;
        private readonly IMapperTaxa _mapper;

        public ApplicationServiceTaxa(IServiceTaxa service, IMapperTaxa mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(TaxaDTO obj)
        {
            var objTaxa = _mapper.MapperToEntity(obj);
            _service.Add(objTaxa);
        }

        public void Dispose()
        {
            _service.Dispose();
        }

        public IEnumerable<TaxaDTO> GetAll()
        {
            var objTaxas = _service.GetAll();
            return _mapper.MapperList(objTaxas);
        }

        public TaxaDTO GetById(int id)
        {
            var objTaxa = _service.GetById(id);
            return _mapper.MapperToDTO(objTaxa);
        }

        public void Remove(TaxaDTO obj)
        {
            var objTaxa = _mapper.MapperToEntity(obj);
            _service.Remove(objTaxa);
        }

        public void Update(TaxaDTO obj)
        {
            var objTaxa = _mapper.MapperToEntity(obj);
            _service.Update(objTaxa);
        }
    }
}
