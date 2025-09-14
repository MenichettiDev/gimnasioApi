using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_menu_perfil")]
    public class MenuPerfil
    {
        [Key]
        [Column("id_acceso")]
        public long IdAcceso { get; set; }

        [Column("id_menu")]
        public long IdMenu { get; set; }

        [Column("id_perfil")]
        public int IdPerfil { get; set; }

        [Column("estado_acceso")]
        public bool EstadoAcceso { get; set; }

        // Navigation properties
        public virtual Menu? Menu { get; set; }
        public virtual Perfil? Perfil { get; set; }
    }
}
