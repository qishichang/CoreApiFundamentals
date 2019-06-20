using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Camp, CampModel>()
                .ForMember(dest => dest.Venue, opt => opt.MapFrom(src => src.Location.VenueName))
                .ReverseMap();
            CreateMap<Talk, TalkModel>()
                .ReverseMap()
                .ForMember(dest => dest.Camp, opt => opt.Ignore())
                .ForMember(dest => dest.Speaker, opt => opt.Ignore());
            CreateMap<Speaker, SpeakerModel>()
                .ReverseMap();
        }
    }
}
