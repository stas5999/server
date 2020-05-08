using WeldingControl.Shared.Constants.Enums;

namespace WeldingControl.Business.Core.Employees.Queries.GetProfile
{
    public class ProfileDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public int OrganizationId { get; set; }

        public Position Position { get; set; }
    }
}