using System.ComponentModel.DataAnnotations.Schema;

namespace Wilczura.Odata.Adapters.Postgres.Entities;

public class Employee
{
    public int EmployeeId { get; set; }

    [Column(TypeName = "citext")]
    public string Name { get; set; } = string.Empty;

    [Column(TypeName = "citext")]
    public string FirstName { get; set; } = string.Empty;

    [Column(TypeName = "citext")]
    public string LastName { get; set; } = string.Empty;

    [Column(TypeName = "citext")]
    public string Title { get; set; } = string.Empty;

    [Column(TypeName = "citext")]
    public string Email {  get; set; } = string.Empty;
}
