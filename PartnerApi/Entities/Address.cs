using System.Linq;

namespace PartnerApi.Entities
{
    public class Address
    {
        public string city { get; set; }
        public string street { get; set; }
        public int? houseNum { get; set; }
        public int? zipCode { get; set; }
    }
}
