using MediatR;
using System.Collections.Generic;

namespace WeldingControl.Business.Core.Employees.Queries.GetCertificates
{
	public class GetCertificatesQuery : IRequest<CertificatesDto>
	{
		public int Id { get; set; }
		public bool ActiveOnly { get; set; }
	}
	public class GetCertificatesQuery2 : IRequest<CertificatesDto>
	{
		public int Id { get; set; }
		public bool ActiveOnly { get; set; }
	}
}
