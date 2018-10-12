using AutoMapper;
using Newtonsoft.Json.Linq;

namespace ConsoleApp8
{
    public class AssetProfile : Profile
    {
        public AssetProfile()
        {
            CreateMap<JObject, AssetDTO>()
                .ForMember(dest => dest.AssetId, o => o.UseValue("100"))
                .ForMember(dest => dest.Type, o => o.MapFrom(j => j["AssetType"]))
                .ForMember(dest => dest.DeviceSerialNumber, o => o.MapFrom(j => j["Device"][0]["SerialNumber"]));
        }
    }
}