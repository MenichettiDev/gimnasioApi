using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_menu")]
    public class Menu
    {
        [Key]
        [Column("id_menu")]
        public long IdMenu { get; set; }

        [Column("menu_descripcion")]
        [StringLength(50)]
        public string MenuDescripcion { get; set; } = string.Empty;

        [Column("menu_icono")]
        [StringLength(30)]
        public string? MenuIcono { get; set; }

        [Column("menu_link")]
        [StringLength(100)]
        public string? MenuLink { get; set; }

        [Column("menu_grupo")]
        [StringLength(10)]
        public string? MenuGrupo { get; set; }

        [Column("menu_principal")]
        public int? MenuPrincipal { get; set; }

        [Column("menu_orden")]
        public int? MenuOrden { get; set; }

        [Column("menu_estado")]
        public bool MenuEstado { get; set; } = true;

        [Column("tipo_ruta")]
        [StringLength(50)]
        public string? TipoRuta { get; set; }
    }
}
