using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_metas")]
    public class Meta
    {
        [Key]
        [Column("id_meta")]
        public int IdMeta { get; set; }

        [Column("id_atleta")]
        public int? IdAtleta { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("tipo_meta")]
        [StringLength(50)]
        public string? TipoMeta { get; set; }

        [Column("valor_objetivo")]
        public decimal? ValorObjetivo { get; set; }

        [Column("fecha_establecimiento")]
        public DateTime? FechaEstablecimiento { get; set; }

        [Column("fecha_vencimiento")]
        public DateTime? FechaVencimiento { get; set; }

        [Column("estado")]
        [StringLength(50)]
        public string? Estado { get; set; }

        // Navigation property
        public virtual Atleta? Atleta { get; set; }
    }
}
