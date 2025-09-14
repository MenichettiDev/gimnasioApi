using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    public enum EstadoAtleta
    {
        activo,
        inactivo
    }

    [Table("tb_atleta")]
    public class Atleta
    {
        [Key]
        [Column("id_atleta")]
        public int IdAtleta { get; set; }

        [Column("id_persona")]
        public int IdPersona { get; set; }

        [Column("id_entrenador")]
        public int? IdEntrenador { get; set; }

        [Column("id_gimnasio")]
        public int? IdGimnasio { get; set; }

        [Column("estado")]
        public EstadoAtleta Estado { get; set; }

        [Column("fecha_registro")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Column("ultimo_pago")]
        public DateTime? UltimoPago { get; set; }

        // Navigation properties
        public virtual Usuario? Usuario { get; set; }
        public virtual Entrenador? Entrenador { get; set; }
        public virtual Gimnasio? Gimnasio { get; set; }
    }
}
