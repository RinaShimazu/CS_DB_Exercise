using CS_DB_Exercise.Infrastructures.Entities;
using CS_DB_Exercise.Infrastructures.Contexts;
namespace CS_DB_Exercise.Infrastructures.Queries;
/// <summary>
/// itemテーブルにアクセスするクラス
/// </summary>
/// <author>Fullness,Inc.</author>
/// <date>2025-11-16</date>
/// <version>1.0.0</version>
public class ItemAccessor
{
    //  アプリケーション用DbContext
    private readonly AppDbContext _context;
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="context">アプリケーション用DbContext</param>
    public ItemAccessor(AppDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// 指定された単価のすべての商品を取得する
    /// </summary>
    /// <param name="price">単価</param>
    /// <returns></returns>
    public List<ItemEntity> FindByPrice(int price)
    {
        var items = _context.Items
        // 引数priceと同じ価格のすべて商品を取得する
        .Where(i => i.Price == price)
        .ToList();
        return items;
    }
}