using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WeldingControl.Data.Infrastructure;

namespace WeldingControl.Business.Core.Employees.Queries.GetCertificates
{
	public class GetCertificatesHandler : IRequestHandler<GetCertificatesQuery, CertificatesDto>
	{
        private readonly DomainContext _context;

        public GetCertificatesHandler(DomainContext context)
        {
            _context = context;
        }

        public async Task<CertificatesDto> Handle(GetCertificatesQuery request, CancellationToken cancellationToken)
        {
            var certificate = await _context.EmployeeCertificates
                .Where(x => x.Id == request.Id)
                .FirstOrDefaultAsync(cancellationToken);

            if (certificate == null)
            {
                throw new ApplicationException("Пользователь не найден");
            }

            var certificate2 = await _context.EmployeeCertificates
                .AsNoTracking()
                .Where(x => x.IssueDate == certificate.IssueDate)
                .Select(x => new CertificatesDto
                {
                    Id = x.Id,
                    IssueDate = x.IssueDate,
                    ExpiresDate = x.ExpiresDate,
                    Thickness = x.Thickness,
                    EmployeeId = x.EmployeeId,
                    PipeOuterDiameter = x.PipeOuterDiameter,
                    Decision = x.Decision,
                })
                .FirstOrDefaultAsync(cancellationToken);

            return certificate2;
        }

        public Task<CertificatesDto> Handle(GetCertificatesHandler request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}