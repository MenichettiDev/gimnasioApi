using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_suscripciones_mp")]
    public class SuscripcionMp
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_persona")]
        public int IdPersona { get; set; }

        [Column("mp_subscription_id")]
        [StringLength(255)]
        public string? MpSubscriptionId { get; set; }

        [Column("mp_preapproval_id")]
        [StringLength(255)]
        public string? MpPreapprovalId { get; set; }

        [Column("estado")]
        [StringLength(50)]
        public string Estado { get; set; } = "activa";

        [Column("tipo_plan")]
        [StringLength(100)]
        public string TipoPlan { get; set; } = "mensual";

        [Column("monto_mensual")]
        public decimal MontoMensual { get; set; }

        [Column("fecha_inicio")]
        public DateTime FechaInicio { get; set; }

        [Column("fecha_fin")]
        public DateTime? FechaFin { get; set; }

        [Column("activa")]
        public bool Activa { get; set; } = true;

        [Column("external_reference")]
        [StringLength(255)]
        public string? ExternalReference { get; set; }

        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;

        [Column("razon")]
        [StringLength(200)]
        public string? Razon { get; set; }

        [Column("frecuencia")]
        [StringLength(50)]
        public string? Frecuencia { get; set; }

        [Column("tipo_frecuencia")]
        [StringLength(50)]
        public string? TipoFrecuencia { get; set; }

        // Navigation property
        public virtual Usuario? Usuario { get; set; }
    }
}
