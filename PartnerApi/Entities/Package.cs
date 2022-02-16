using Api;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PartnerApi.Entities
{
    public class Package
    {

            public string name { get; set; }

            //[JsonConverter(typeof(StringEnumConverter))]
            public PackageType type { get; set; }

            public int quantity { get; set; }
            public int utilization { get; set; }
  
    }
}
