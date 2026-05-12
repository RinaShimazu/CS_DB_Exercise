using CS_DB_Exercise.Infrastructures.Entities;
using CS_DB_Exercise.Infrastructures.Contexts;
namespace CS_DB_Exercise.Infrastructures.Accessors;
/// <summary>
/// departmentテーブルにアクセスするクラス
/// </summary>
/// <author>Fullness,Inc.</author>
/// <date>2025-11-16</date>
/// <version>1.0.0</version>
public class EmployeeAccessor
{
    //  アプリケーション用DbContext
    private readonly AppDbContext _context;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="context">アプリケーション用DbContext</param>
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

    public EmployeeEntity? FindByDeptId(int deptId)
    {
        // Find()メソッドを使用して、指定した部署Idの部署を取得する
        var dept_id = _context.Departments.Find(deptId);
        return dept_id;
    }
}