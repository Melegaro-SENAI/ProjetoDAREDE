using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.ProjetoDAREDE.Dominio.Entidades
{
    [Table("Servicos")]
    public class ServicosDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("NomeServico", TypeName = "Varchar(255)")]
        public string Nome { get; set; }

        [Required]
        [Column("DescricaoServico", TypeName = "Text(1000)")]
        public string Descricao { get; set; }

        [Required]
        [Column("ValorServiço", TypeName = "decimal(18, 6)")]
        public float Valor { get; set; }
    }
}
