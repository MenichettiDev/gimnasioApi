using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gimnasioApi.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [Column("id_usuario")]
        public int Id { get; set; }

        [Column("nombre")]
        [StringLength(50)]
        public string? Nombre { get; set; } = string.Empty;

        [Column("apellido")]
        [StringLength(50)]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [Column("dni")]
        [StringLength(20)]
        public string Dni { get; set; } = string.Empty;

        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Column("email")]
        [StringLength(100)]
        public string? Email { get; set; }

        [Column("celular")]
        [StringLength(15)]
        public string? Telefono { get; set; }

        [Column("direccion")]
        [StringLength(100)]
        public string? Direccion { get; set; }

        [Column("foto_archivo")]
        [StringLength(200)]
        public string? Avatar { get; set; }

        [Required]
        [Column("id_acceso")]
        public int RolId { get; set; }

        [Column("accede_al_sistema")]
        public bool AccedeAlSistema { get; set; } = true;

        [Column("activo")]
        public bool Activo { get; set; } = true;


        [Column("password")]
        [StringLength(200)]
        public string? PasswordHash { get; set; } // Contraseña encriptada

        [NotMapped]
        public string? Password { get; set; } // Recibe la contraseña en texto plano, pero no se guarda en la DB

        [Column("fecha_registro")]
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        public int IdUsuarioCrea { get; set; }

        public int? IdUsuarioModifica { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [ForeignKey("RolId")]
        public Rol Rol { get; set; } = null!;

        [Column("ultimo_pago")]
        public DateTime UltimoPago { get; set; } = DateTime.Now;

        [Column("tiene_suscripcion_activa")]
        public bool TieneSuscripcionActiva { get; set; } = false;

        [Column("fecha_ultima_suscripcion")]
        public DateTime? FechaUltimaSuscripcion { get; set; }
    }
}
