using AutoMapper;
using Newtonsoft.Json;
using PartnerApi.Entities;
using AutoMapper.Extensions.EnumMapping;
using Api;

namespace Api
{
    public class CustomerBL : ICustomerBL
    {
        private readonly IMapper _mapper;

        public CustomerBL(IMapper mapper)
        {
           
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
             
        }
      

        public List<Customer> LoadJson() 
        {
            using (StreamReader r = new StreamReader("customers.json"))
            {
                string json = r.ReadToEnd();
                List<Customer> items = JsonConvert.DeserializeObject<List<Customer>>(json);

                return items;
            }
        }

    }
}

//public class EnumProfile : Profile
//{
//    public EnumProfile()
//    {

//        CreateMap<MemberType, TargetMemberType>()
//          .ConvertUsingEnumMapping(o => o
//          .MapByName()
//              .MapValue(MemberType.Bussiness, TargetMemberType.Bussiness)
//              .MapValue(MemberType.Private, TargetMemberType.Private)
//           )
//        .ReverseMap();

//        CreateMap<PackageType, TargetPackageType>()
//               .ConvertUsingEnumMapping(o => o
//               .MapByName()
//                   .MapValue(PackageType.AbroadCalls, TargetPackageType.AbroadCalls)
//                   .MapValue(PackageType.Browsing, TargetPackageType.Browsing)
//                   .MapValue(PackageType.BrowsingVolume, TargetPackageType.BrowsingVolume)
//                   .MapValue(PackageType.LocalCalls, TargetPackageType.LocalCalls)
//                   .MapValue(PackageType.Sms, TargetPackageType.Sms)
//       )
//       .ReverseMap();

//    }
//}



