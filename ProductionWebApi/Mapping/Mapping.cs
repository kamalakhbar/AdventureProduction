using AutoMapper;
using Production.Entities.DTO;
using Production.Entities.Models;

namespace ProductionWebApi.Mapping
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
