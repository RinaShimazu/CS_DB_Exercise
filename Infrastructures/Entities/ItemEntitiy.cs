using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CS_DB_Exercise.Infrastructures.Entities;


[Table("item")]

public class ItemEntity
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("price")]
    public int Price { get; set; }


    public override string? ToString()
    {
        return $"商品Id:{Id},商品名:{Name},価格:{Price}";
    }

}