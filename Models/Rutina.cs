using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    public enum CantidadDias
    {
        [Display(Name = "1")]
        Uno = 1,
        [Display(Name = "2")]
        Dos = 2,
        [Display(Name = "3")]
        Tres = 3,
        [Display(Name = "4")]
        Cuatro = 4,
        [Display(Name = "5")]
        Cinco = 5,
        [Display(Name = "6")]
        Seis = 6,
        [Display(Name = "7")]
        Siete = 7
    }

    public enum NivelAtleta
    {
        Principiante,
        Intermedio,
        Avanzado
    }

    public enum ObjetivoRutina
    {
        Musculacion,
        Tonificacion,
        Resistencia,
        Peso
    }

    [Table("tb_rutina")]
    public class Rutina
    {
        [Key]
        [Column("id_rutina")]
        public int IdRutina { get; set; }

        [Column("id_creador")]
        public int IdCreador { get; set; }

        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Column("cantidad_dias")]
        public CantidadDias CantidadDias { get; set; }

        [Column("nivel_atleta")]
        public NivelAtleta NivelAtleta { get; set; }

        [Column("objetivo")]
        public ObjetivoRutina Objetivo { get; set; }

        [Column("descripcion")]
        [StringLength(200)]
        public string? Descripcion { get; set; }

        // Navigation property
        public virtual Usuario? Creador { get; set; }
    }
}
