using CS_DB_Exercise.Infrastructures.Entities;
using CS_DB_Exercise.Infrastructures.Contexts;

namespace CS_DB_Exercise.Infrastructures.Accessors;

public class EmployeeAccessor
{
    private readonly AppDbContext _context;


    public EmployeeAccessor(AppDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// すべての部署を取得する
    /// </summary>
    public List<EmployeeEntity> FindAll()
    {
        // ToList()メソッドを使用して、すべての部署を取得する
        var employees = _context.Employees.ToList();
        return employees;
    }

    public DepartmentEntity? FindByDeptId(int deptId)
    {
        // Find()メソッドを使用して、指定した部署Idの部署を取得する
        var dept = _context.Departments.Find(deptId);
        return dept;
    }
}