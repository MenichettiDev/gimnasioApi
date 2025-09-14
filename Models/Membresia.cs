using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    public enum TipoMembresia
    {
        mensual,
        anual,
        semanal,
        trimestral
    }

    public enum EstadoMembresia
    {
        activo,
        inactivo
    }

    [Table("tb_membresia")]
    public class Membresia
    {
        [Key]
        [Column("id_membresia")]
        public int IdMembresia { get; set; }

        [Column("id_gimnasio")]
        public int IdGimnasio { get; set; }

        [Column("nombre")]
        [StringLength(255)]
        public string Nombre { get; set; } = string.Empty;

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("precio")]
        public decimal Precio { get; set; }

        [Column("duracion")]
        public int Duracion { get; set; }

        [Column("tipo")]
        public TipoMembresia Tipo { get; set; }

        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Column("estado")]
        public EstadoMembresia Estado { get; set; } = EstadoMembresia.activo;

        // Navigation property
        public virtual Gimnasio? Gimnasio { get; set; }
    }
}
