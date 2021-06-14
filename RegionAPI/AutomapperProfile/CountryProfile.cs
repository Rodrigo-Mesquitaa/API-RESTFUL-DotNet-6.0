using AutoMapper;
using RegionAPI.Models;
using RegionAPI.ViewModels;

namespace RegionAPI.AutomapperProfile
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<CountryModel, CountryViewModel>()
            .ReverseMap();
        }
    }
}
