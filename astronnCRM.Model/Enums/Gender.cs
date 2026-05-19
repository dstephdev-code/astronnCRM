using System.Runtime.Serialization;

namespace astronnCRM.Model.Enums
{
    public enum Gender
    {
        [EnumMember(Value = "Male")]
        Male,
        [EnumMember(Value = "Female")]
        Female,
        [EnumMember(Value = "Secret")]
        Secret
    }
}
