using WeldingControl.Shared.Constants.Enums;

namespace WeldingControl.Presentation.Web.Auth
{
    public class JwtUserData
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public int OrganizationId { get; set; }

        public Position Position { get; set; }
    }
}