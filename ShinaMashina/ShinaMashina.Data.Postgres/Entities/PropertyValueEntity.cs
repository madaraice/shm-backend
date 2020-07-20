using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShinaMashina.Data.Postgres.Entities
{
    public class PropertyValueEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(PropertyEntity))]
        public int PropertyId { get; set; }

        public PropertyEntity Property { get; set; }

        [ForeignKey(nameof(ProductEntity))]
        public int ProductId { get; set; }

        public ProductEntity Product { get; set; }

        // TODO нужен ValueType
        public string Value { get; set; }
    }
}
