using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Api
{

    public enum PackageType
    {
        [EnumMember(Value = "Sms")]
        Sms,
        [EnumMember(Value = "LocalCalls")]
        LocalCalls,
        [EnumMember(Value = "AbroadCalls")]
        AbroadCalls,
        [EnumMember(Value = "BrowsingVolume")]
        BrowsingVolume,
        [EnumMember(Value = "Browsing")]
        Browsing
    };

    public enum MemberType
    {
        [EnumMember(Value = "Private")]
        Private,
        [EnumMember(Value = "Bussiness")]
        Bussiness
    };

    public enum TargetPackageType
    {
        Sms,
        LocalCalls,
        AbroadCalls,
        BrowsingVolume,
        Browsing
    };

    public enum TargetMemberType
    {
        Private,
        Bussiness
    };

}
