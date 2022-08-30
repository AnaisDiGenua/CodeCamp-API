using AutoMapper;
using CoreCodeCamp.Data.Entities;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>()
                //per mappare una proprietà dall'entità location
              .ForMember(c => c.Venue, o => o.MapFrom(m => m.Location.VenueName));
        }
    }
}
