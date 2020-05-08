using MediatR;

namespace WeldingControl.Business.Core.Employees.Queries.GetProfile
{
    public class GetProfileQuery: IRequest<ProfileDto>
    {
        public string UserName { get; set; }
    }
}