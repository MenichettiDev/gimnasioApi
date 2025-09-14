using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_pago")]
    public class Pago
    {
        [Key]
        [Column("id_pago")]
        public int IdPago { get; set; }

        [Column("id_persona")]
        public int IdPersona { get; set; }

        [Column("fecha_pago")]
        public DateTime FechaPago { get; set; } = DateTime.Now;

        [Column("monto")]
        public decimal Monto { get; set; }

        [Column("concepto")]
        [StringLength(100)]
        public string Concepto { get; set; } = string.Empty;

        [Column("id_forma_pago")]
        public int IdFormaPago { get; set; }

        [Column("mp_payment_id")]
        [StringLength(255)]
        public string? MpPaymentId { get; set; }

        [Column("mp_status")]
        [StringLength(50)]
        public string? MpStatus { get; set; }

        [Column("mp_subscription_id")]
        [StringLength(255)]
        public string? MpSubscriptionId { get; set; }

        // Navigation properties
        public virtual Usuario? Usuario { get; set; }
        public virtual FormaPago? FormaPago { get; set; }
    }
}
