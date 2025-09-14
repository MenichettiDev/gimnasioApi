using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_rutina_favorita")]
    public class RutinaFavorita
    {
        [Column("id_atleta")]
        public int IdAtleta { get; set; }

        [Column("id_rutina")]
        public int IdRutina { get; set; }

        // Navigation properties
        public virtual Atleta? Atleta { get; set; }
        public virtual Rutina? Rutina { get; set; }
    }
}
