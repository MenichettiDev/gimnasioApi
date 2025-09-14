using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    public enum EstadoGimnasio
    {
        activo,
        inactivo
    }

    [Table("tb_gimnasio")]
    public class Gimnasio
    {
        [Key]
        [Column("id_gimnasio")]
        public int IdGimnasio { get; set; }

        [Column("id_persona")]
        public int IdPersona { get; set; }

        [Column("nombre")]
        [StringLength(255)]
        public string Nombre { get; set; } = string.Empty;

        [Column("direccion")]
        [StringLength(255)]
        public string? Direccion { get; set; }

        [Column("telefono")]
        [StringLength(15)]
        public string? Telefono { get; set; }

        [Column("horario_apertura")]
        public TimeSpan? HorarioApertura { get; set; }

        [Column("horario_cierre")]
        public TimeSpan? HorarioCierre { get; set; }

        [Column("estado")]
        public EstadoGimnasio Estado { get; set; } = EstadoGimnasio.activo;

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("fecha_registro")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Column("pagina_web")]
        [StringLength(100)]
        public string? PaginaWeb { get; set; }

        [Column("foto")]
        [StringLength(100)]
        public string? Foto { get; set; }

        [Column("ultimo_pago")]
        public DateTime? UltimoPago { get; set; }

        // Navigation property
        public virtual Usuario? Usuario { get; set; }
    }
}
