using AutoMapper;
using Newtonsoft.Json;
using PartnerApi.Entities;
using AutoMapper.Extensions.EnumMapping;
using Api;

namespace Api
{
    public interface ICustomerBL
    {
        public List<Customer> LoadJson(); 

    }
}
