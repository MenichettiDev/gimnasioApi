using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_rutina_atleta")]
    public class RutinaAtleta
    {
        [Key]
        [Column("id_rutina_atleta")]
        public int IdRutinaAtleta { get; set; }

        [Column("id_rutina")]
        public int IdRutina { get; set; }

        [Column("id_atleta")]
        public int IdAtleta { get; set; }

        [Column("fecha_asignacion")]
        public DateTime FechaAsignacion { get; set; }

        // Navigation properties
        public virtual Rutina? Rutina { get; set; }
        public virtual Atleta? Atleta { get; set; }
    }
}
