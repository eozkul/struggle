using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Struggle.Common
{
    public class EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

    }
}
