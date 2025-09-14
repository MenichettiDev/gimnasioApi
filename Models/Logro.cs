using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_logros")]
    public class Logro
    {
        [Key]
        [Column("id_logro")]
        public int IdLogro { get; set; }

        [Column("id_atleta")]
        public int? IdAtleta { get; set; }

        [Column("nombre_logro")]
        [StringLength(255)]
        public string? NombreLogro { get; set; }

        [Column("descripcion_logro")]
        public string? DescripcionLogro { get; set; }

        [Column("fecha")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        // Navigation property
        public virtual Atleta? Atleta { get; set; }
    }
}
