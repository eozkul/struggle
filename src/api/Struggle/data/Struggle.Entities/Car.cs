using Struggle.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Struggle.Entities
{
    [Table("Cars")]
    public class Car:EntityBase
    {
        [Required]
        public bool HeadLights { get; set; }    
    }
}
