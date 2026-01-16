using System.ComponentModel.DataAnnotations;

namespace FBTrajeta.Models
{
    public class TrajetaCredito
    {
        public int Id { get; set; }
        [Required]
        public string titular { get; set; }
        [Required]
        public string numeroTrajeta { get; set; }
        [Required]
        public string fechaExpiracion { get; set; }
        [Required]
        public string cvv { get; set; }
        [Required]
        public string tipo { get; set; }
    }
}
