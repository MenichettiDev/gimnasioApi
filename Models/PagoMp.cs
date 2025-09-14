using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_pagos_mp")]
    public class PagoMp
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_suscripcion_mp")]
        public int IdSuscripcionMp { get; set; }

        [Column("id_persona")]
        public int IdPersona { get; set; }

        [Column("mp_payment_id")]
        [StringLength(255)]
        public string MpPaymentId { get; set; } = string.Empty;

        [Column("monto")]
        public decimal Monto { get; set; }

        [Column("estado")]
        [StringLength(50)]
        public string Estado { get; set; } = string.Empty;

        [Column("fecha_pago")]
        public DateTime FechaPago { get; set; }

        [Column("tipo_pago")]
        [StringLength(50)]
        public string TipoPago { get; set; } = "recurrente";

        [Column("concepto")]
        public string? Concepto { get; set; }

        [Column("mp_status_detail")]
        [StringLength(100)]
        public string? MpStatusDetail { get; set; }

        [Column("mp_payment_method_id")]
        [StringLength(50)]
        public string? MpPaymentMethodId { get; set; }

        [Column("mp_transaction_amount")]
        public decimal? MpTransactionAmount { get; set; }

        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;

        // Navigation properties
        public virtual SuscripcionMp? SuscripcionMp { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}
