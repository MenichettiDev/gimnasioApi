using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_forma_pago")]
    public class FormaPago
    {
        [Key]
        [Column("id_forma_pago")]
        public int IdFormaPago { get; set; }

        [Column("nombre")]
        [StringLength(20)]
        public string Nombre { get; set; } = string.Empty;
    }
}
