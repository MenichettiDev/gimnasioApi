using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_asistencia")]
    public class Asistencia
    {
        [Key]
        [Column("id_asistencia")]
        public int IdAsistencia { get; set; }

        [Column("id_atleta")]
        public int? IdAtleta { get; set; }

        [Column("fecha")]
        public DateTime? Fecha { get; set; }

        [Column("asistio")]
        public bool Asistio { get; set; } = false;

        // Navigation property
        public virtual Atleta? Atleta { get; set; }
    }
}
