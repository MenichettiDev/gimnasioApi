using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_grupos_musculares")]
    public class GrupoMuscular
    {
        [Key]
        [Column("id_grupo_muscular")]
        public int IdGrupoMuscular { get; set; }

        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}
