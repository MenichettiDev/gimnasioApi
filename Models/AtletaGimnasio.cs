using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_atleta_gimnasio")]
    public class AtletaGimnasio
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_atleta")]
        public int? IdAtleta { get; set; }

        [Column("id_gimnasio")]
        public int? IdGimnasio { get; set; }

        [Column("activo")]
        public int Activo { get; set; } = 0;

        // Navigation properties
        public virtual Atleta? Atleta { get; set; }
        public virtual Gimnasio? Gimnasio { get; set; }
    }
}
