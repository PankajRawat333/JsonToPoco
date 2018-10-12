namespace ConsoleApp8
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(x => x.AddProfile<AssetProfile>());
        }
    }
}