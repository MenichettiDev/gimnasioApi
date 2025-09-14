using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_perfil")]
    public class Perfil
    {
        [Key]
        [Column("id_perfil")]
        public int IdPerfil { get; set; }

        [Column("nombre_perfil")]
        [StringLength(100)]
        public string NombrePerfil { get; set; } = string.Empty;

        [Column("estado")]
        public bool Estado { get; set; } = true;
    }
}
