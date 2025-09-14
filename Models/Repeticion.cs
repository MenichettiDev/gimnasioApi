using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_repeticion")]
    public class Repeticion
    {
        [Key]
        [Column("id_repeticion")]
        public int IdRepeticion { get; set; }

        [Column("nombre")]
        [StringLength(20)]
        public string Nombre { get; set; } = string.Empty;

        [Column("frecuencia")]
        [StringLength(50)]
        public string Frecuencia { get; set; } = string.Empty;

        [Column("comentario")]
        [StringLength(500)]
        public string? Comentario { get; set; }
    }
}
