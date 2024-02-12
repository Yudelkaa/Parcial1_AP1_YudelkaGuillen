using System.ComponentModel.DataAnnotations;

namespace Parcial1_AP1_YudelkaGuillen.Models
{
    public class Metas
    {
        [Key]

        public int MetasId { get; set; }

        [Required(ErrorMessage ="Es requerido")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1900-01-01", "2100-12-31")]
        public DateTime? Fecha { get; set; }
        [Required(ErrorMessage = "Es requerido")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "Es requerido")]
        public double Monto { get; set; }
    }
}
