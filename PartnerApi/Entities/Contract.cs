using Api;
using AutoMapper;
using Newtonsoft.Json.Converters;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PartnerApi.Entities
{
    public class Contract
    {
        public string memberNumber { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        public MemberType type { get; set; }
     

        public string firstName { get; set; }

        public string lastName { get; set; }
                    
        public List<Package> packages { get; set; }


    }
}
