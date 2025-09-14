using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_ejercicios")]
    public class Ejercicio
    {
        [Key]
        [Column("id_ejercicio")]
        public int IdEjercicio { get; set; }

        [Column("id_grupo_muscular")]
        public int IdGrupoMuscular { get; set; }

        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Column("img_1")]
        [StringLength(200)]
        public string? Img1 { get; set; }

        [Column("img_2")]
        [StringLength(200)]
        public string? Img2 { get; set; }

        [Column("img_3")]
        [StringLength(200)]
        public string? Img3 { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("link_video")]
        [StringLength(200)]
        public string? LinkVideo { get; set; }

        // Navigation property
        public virtual GrupoMuscular? GrupoMuscular { get; set; }
    }
}
