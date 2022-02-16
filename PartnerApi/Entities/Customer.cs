namespace PartnerApi.Entities
{
    public class Customer
    {


            public string customerId { get; set; }

            public string firstName { get; set; }
            public string lastName { get; set; }

            public Address address { get; set; }

            public List<Contract> contracts { get; set; }


    }
}
