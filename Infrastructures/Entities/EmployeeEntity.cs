using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CS_DB_Exercise.Infrastructures.Entities;

[Table("employee")]

public class EmployeeEntity
{
    [Key]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("dept_id")]
    public int DeptId { get; set; }


    public override string? ToString()
    {
        return $"社員Id:{Id},社員名:{Name},部署Id:{DeptId}";
    }

}



