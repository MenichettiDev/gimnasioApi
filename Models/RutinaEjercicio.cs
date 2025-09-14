using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_rutina_ejercicios")]
    public class RutinaEjercicio
    {
        [Key]
        [Column("id_rutina_ejercicios")]
        public int IdRutinaEjercicios { get; set; }

        [Column("id_rutina")]
        public int IdRutina { get; set; }

        [Column("id_ejercicios")]
        public int IdEjercicios { get; set; }

        [Column("id_repeticion")]
        public int IdRepeticion { get; set; }

        [Column("id_grupo_muscular")]
        public int IdGrupoMuscular { get; set; }

        [Column("dia")]
        public int Dia { get; set; }

        // Navigation properties
        public virtual Rutina? Rutina { get; set; }
        public virtual Ejercicio? Ejercicio { get; set; }
        public virtual Repeticion? Repeticion { get; set; }
        public virtual GrupoMuscular? GrupoMuscular { get; set; }
    }
}
