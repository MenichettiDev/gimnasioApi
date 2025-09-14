using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_objetivo")]
    public class Objetivo
    {
        [Key]
        [Column("id_objetivo")]
        public int IdObjetivo { get; set; }

        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}
