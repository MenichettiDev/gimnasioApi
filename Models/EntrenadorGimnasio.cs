using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_entrenador_gimnasio")]
    public class EntrenadorGimnasio
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_entrenador")]
        public int IdEntrenador { get; set; }

        [Column("id_gimnasio")]
        public int IdGimnasio { get; set; }

        [Column("activo")]
        public int Activo { get; set; } = 0;

        // Navigation properties
        public virtual Entrenador? Entrenador { get; set; }
        public virtual Gimnasio? Gimnasio { get; set; }
    }
}
