using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShinaMashina.Data.Postgres.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey(nameof(CategoryEntity))]
        public int CategoryId { get; set; }

        public CategoryEntity Category { get; set; }
    }
}
