using WeldingControl.Shared.Constants.Enums;

namespace WeldingControl.Business.Core.Employees.Queries.GetCertificates
{
    public class CertificatesDto
    {

    public int Id { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime ExpiresDate { get; set; }

    public int EmployeeId { get; set; }

    public Param Thickness { get; set; }

    public Param PipeOuterDiameter { get; set; }

    public string Decision { get; set; }

    public Employee Employee { get; set; }
    }
}
