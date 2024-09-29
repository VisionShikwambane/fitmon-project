using AutoMapper;
using fitmon_datamodels;

namespace fitmon_api
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Test, Test>().ReverseMap();

        }

    }
}
