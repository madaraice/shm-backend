using System.ComponentModel.DataAnnotations;

namespace ShinaMashina.Data.Postgres.Entities
{
    public class PropertyEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        // TODO нужен ValueType
        public string Type { get; set; }
    }
}
