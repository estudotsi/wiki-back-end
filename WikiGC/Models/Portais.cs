using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiGC.Models
{
    [Table("Portais")]
    public class Portais
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do portal deve ser informado")]
        public string? Nome { get; set; }
        public string? UrlProducao { get; set; }
        public string? ServidorProducao { get; set; }
        public string? VersaoWordpressProducao { get; set; }
        public string? UrlHomologacao { get; set; }
        public string? ServidorHomologacao { get; set; }
        public string? VersaoWordpressHomologacao { get; set; }
        public string? Responsavel { get; set; }

    }
}
