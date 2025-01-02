using All_Social_media_apps_apis.DTO;
using All_Social_media_apps_apis.Models;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace All_Social_media_apps_apis.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Emails, EmailDTO>().ReverseMap();
        }
    }
}
