using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WeldingControl.Data.Infrastructure;

namespace WeldingControl.Business.Core.Employees.Queries.GetCertificates
{
	public class GetCertificatesHandler : IRequestHandler<GetCertificatesHandler, CertificatesDto>
	{
        private readonly DomainContext _context;

        public GetCertificatesHandler(DomainContext context)
        {
            _context = context;
        }

        public async Task<CertificatesDto> Handle(GetCertificatesQuery request, CancellationToken cancellationToken)
        {
            var certificate = await _context.EmployeeCertificate
                .Select(x => new CertificatesDto
                {
                    Id = x.Id,
                    IssueDate = x.IssueDateId,
                    ExpiresDate = x.ExpiresDateId,
                    Thickness = x.ThicknessId,
                    PipeOuterDiameter = x.PipeOuterDiameterId,
                    Decision = x.DecisionId,
                    Employee = x.EmployeeId
                })
                .FirstOrDefaultAsync(cancellationToken);

            return certificate;
        }
    }
}