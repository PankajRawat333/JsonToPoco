using AutoMapper;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AutoMapperConfiguration.Configure();

            string json = File.ReadAllText("jsonData.json");
            JArray assets = JArray.Parse(json);
            List<AssetDTO> assetDTOList = Mapper.Map<List<AssetDTO>>(assets);
        }
    }
}