using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_nivel_dificultad")]
    public class NivelDificultad
    {
        [Key]
        [Column("id_nivel")]
        public int IdNivel { get; set; }

        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}
