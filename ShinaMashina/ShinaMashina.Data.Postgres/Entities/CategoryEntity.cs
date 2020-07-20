using System.ComponentModel.DataAnnotations;

namespace ShinaMashina.Data.Postgres.Entities
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
