using System.ComponentModel.DataAnnotations;

namespace graphapi.Data
{
    public class Personn
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
