using CS_DB_Exercise.Infrastructures;
using CS_DB_Exercise.Infrastructures.Queries;
using CS_DB_Exercise.Infrastructures.Contexts;


namespace CS_DB_Exercise;

class Program
{
    static void Main(string[] args)
    {
        /*
        var accessor = new DepartementAccessor(new AppDbContext());
        // すべての部署を取得する
        var departments = accessor.FindAll();
        Console.WriteLine("すべての部署を取得する");
        foreach (var d in departments)
        {
            Console.WriteLine(d);
        }

        // 指定した部署Idの部署を取得する(存在する部署Id)
        var department = accessor.FindById(1);
        Console.WriteLine($"存在する部署Id:{department!.ToString()}");

        // 指定した部署Idの部署を取得する(存在しない部署Id)
        department = accessor.FindById(101);
        if (department == null)
        {
            Console.WriteLine($"部署Id:101の部署は存在しません。");
        }
        */


        var accessor2 = new ItemAccessor(new AppDbContext());
        var items = accessor2.FindByPrice(120);
        // 取得した商品情報を表示する
        Console.WriteLine("単価120の商品を取得する");
        foreach (var item in items)
        {
            Console.WriteLine($"商品名：{item.Name} 単価：{item.Price}");
        }
    }

}