using AutoMapper;
using Newtonsoft.Json.Linq;

namespace ConsoleApp8
{
    public class AssetProfile : Profile
    {
        public AssetProfile()
        {
            CreateMap<JObject, AssetDTO>()
                .ForAllMembers(dest => dest.Ignore());

            CreateMap<JObject, AssetDTO>()
                .ForMember(dest => dest.AssetId, o => o.MapFrom(j => j["AssetId"]))
                .ForMember(dest => dest.Type, o => o.MapFrom(j => j["AssetType"]))
                .ForMember(dest => dest.DeviceSerialNumber, o => o.MapFrom(j => JArray.Parse(j["Device"].ToString())[0]["SerialNumber"]));
        }
    }
}