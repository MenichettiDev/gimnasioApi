using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    public enum EstadoEntrenador
    {
        activo,
        inactivo
    }

    [Table("tb_entrenador")]
    public class Entrenador
    {
        [Key]
        [Column("id_entrenador")]
        public int IdEntrenador { get; set; }

        [Column("id_persona")]
        public int IdPersona { get; set; }

        [Column("fecha_ingreso")]
        public DateTime FechaIngreso { get; set; }

        [Column("estado")]
        public EstadoEntrenador Estado { get; set; }

        // Navigation property
        public virtual Usuario? Usuario { get; set; }
    }
}
