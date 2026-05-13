using Microsoft.EntityFrameworkCore;

using CS_DB_Exercise.Infrastructures.Accessors;
using CS_DB_Exercise.Infrastructures.Contexts;
using CS_DB_Exercise.Infrastructures.Entities;

namespace CS_DB_Exercise;

class Program
{
    static void Main(string[] args)
    {
        // 演習用DbContextを生成する
        var context = new AppDbContext();

        // departmentテーブルアクセスクラスを生成する
        var departmentAccessor = new DepartmentAccessor(context);

        var employeeAccessor = new EmployeeAccessor(context);

        Exercise16(employeeAccessor);
    }

    /*
        /// <summary>
        /// 演習-15 トランザクション制御機能を確認する
        /// </summary>
        /// <param name="context">演習用DbContext</param>
        /// <param name="departmentAccessor">Departmentテーブルアクセスクラス</param>
        /// <returns></returns>
        private static void Exercise15(DbContext context, DepartmentAccessor departmentAccessor)
        {
            using var transaction = context.Database.BeginTransaction();
            Console.WriteLine("トランザクションを開始しました。");

            Console.Write("新しい部署名を入力してください->");
            var name = Console.ReadLine();
            var entity = new DepartmentEntity
            {
                Id = 0, // Idは自動採番されるため、0を指定する
                Name = name
            };
            // Create()メソッドを使用して、departmentテーブルに新しい部署を登録する
            var result = departmentAccessor.Create(entity);
            Console.WriteLine($"新しい部署を登録しました: 部署Id={result.Id} , 部署名={result.Name}");

            Console.Write("トランザクションをコミットしますか？ (y/n)->");
            var input = Console.ReadLine();
            if (input?.ToLower() == "y")
            {
                // トランザクションをコミットする
                transaction.Commit();
                Console.WriteLine("トランザクションをコミットしました。");
            }
            else
            {
                // トランザクションをロールバックする
                transaction.Rollback();
                Console.WriteLine("トランザクションをロールバックしました。");
            }

            // 登録した部署を含むすべての部署を取得して表示する
            var departments = departmentAccessor.FindAll();
            foreach (var department in departments)
            {
                Console.WriteLine($"部署Id={department.Id} , 部署名={department.Name}");
            }
        }*/
    private static void Exercise16(EmployeeAccessor employeeAccessor)
    {
        Console.Write("社員名を入力してください->");
        var name = Console.ReadLine();
        // 入力された社員名を含む社員とその所属部署を取得する
        var results = employeeAccessor.FindByNameContainsJoinDepartment(name!);
        // 取得した結果がnullの場合は、該当する社員が存在しない旨を表示する
        if (results == null)
        {
            Console.WriteLine($"{name}さんは、存在しません。");
        }
        else
        {
            // 取得した結果をループで回して、社員名と所属部署名を表示する
            foreach (var result in results)
            {
                Console.WriteLine($"{name}さんは、{result.Department!.Name}に所属する社員です。");
            }
        }
    }
}