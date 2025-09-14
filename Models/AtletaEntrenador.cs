using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_atleta_entrenador")]
    public class AtletaEntrenador
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_atleta")]
        public int? IdAtleta { get; set; }

        [Column("id_entrenador")]
        public int? IdEntrenador { get; set; }

        [Column("activo")]
        public int Activo { get; set; } = 0;

        // Navigation properties
        public virtual Atleta? Atleta { get; set; }
        public virtual Entrenador? Entrenador { get; set; }
    }
}
