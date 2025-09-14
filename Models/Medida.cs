using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("tb_medidas")]
    public class Medida
    {
        [Key]
        [Column("id_medida")]
        public int IdMedida { get; set; }

        [Column("id_atleta")]
        public int IdAtleta { get; set; }

        [Column("fecha_medicion")]
        public DateTime FechaMedicion { get; set; }

        [Column("peso")]
        public decimal? Peso { get; set; }

        [Column("altura")]
        public decimal? Altura { get; set; }

        [Column("biceps")]
        public decimal? Biceps { get; set; }

        [Column("pecho")]
        public decimal? Pecho { get; set; }

        [Column("hombros")]
        public decimal? Hombros { get; set; }

        [Column("cintura")]
        public decimal? Cintura { get; set; }

        [Column("gluteos")]
        public decimal? Gluteos { get; set; }

        [Column("cuadriceps")]
        public decimal? Cuadriceps { get; set; }

        [Column("gemelos")]
        public decimal? Gemelos { get; set; }

        [Column("antebrazo")]
        public decimal? Antebrazo { get; set; }

        [Column("cuello")]
        public decimal? Cuello { get; set; }

        [Column("grasa_corporal")]
        public decimal? GrasaCorporal { get; set; }

        // Navigation property
        public virtual Atleta? Atleta { get; set; }
    }
}
