using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_frases")]
    public class Frase
    {
        [Key]
        [Column("id_frase")]
        public int IdFrase { get; set; }

        [Column("frase")]
        [StringLength(500)]
        public string FraseTexto { get; set; } = string.Empty;
    }
}
