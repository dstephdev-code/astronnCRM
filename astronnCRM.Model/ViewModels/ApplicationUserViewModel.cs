using astronnCRM.Model.Enums;

namespace astronnCRM.Model.ViewModels
{
    public class ApplicationUserViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfRegistration { get; set; }
        public short? VerificationCode { get; set; }
        public string? ImageName { get; set; }
        public bool? Activity { get; set; }
    }
}
