using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WeldingControl.Data.Infrastructure;

namespace WeldingControl.Business.Core.Employees.Queries.GetProfile
{
    public class GetProfileQueryHandler: IRequestHandler<GetProfileQuery, ProfileDto>
    {
        private readonly DomainContext _context;

        public GetProfileQueryHandler(DomainContext context)
        {
            _context = context;
        }

        public async Task<ProfileDto> Handle(GetProfileQuery request, CancellationToken cancellationToken)
        {
            var profile = await _context.Employees
                .Where(x => x.UserName == request.UserName)
                .Select(x => new ProfileDto
                {
                    Id = x.Id,
                    OrganizationId = x.OrganizationId,
                    LastName = x.LastName,
                    FirstName = x.FirstName,
                    MiddleName = x.MiddleName,
                    Position = x.Position,
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (profile == null)
            {
                throw new ApplicationException("Профиль пользователя не найден");
            }

            return profile;
        }
    }
}