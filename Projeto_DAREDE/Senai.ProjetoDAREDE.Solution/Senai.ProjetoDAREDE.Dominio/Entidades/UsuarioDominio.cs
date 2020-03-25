using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.ProjetoDAREDE.Dominio.Entidades
{
    [Table("Usuario")]
    public class UsuarioDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Nome", TypeName = "Varchar(255)")]
        public string Nome { get; set; }

        [Required]
        [Column("Email", TypeName = "Varchar(255)")]
        public string Email { get; set; }

        [Required]
        [Column("Senha", TypeName = "Varchar(255)")]
        public string Senha { get; set; }

        [Required]
        [Column("CPF", TypeName = "Varchar(255)")]
        public string CPF { get; set; }

        [Required]
        [Column("Nome da Empresa", TypeName = "Varchar(255)")]
        public string NomeEmpresa { get; set; }

        [ForeignKey("TipoCliente")]
        public int IdTipoCliente { get; set; }

        public TipoCliente TipoCliente { get; set; }
      
        // Se for o Grupo de empresas continuar abaixo.
    
        [Required]
        [Column("Nome do Grupo", TypeName = "Varchar(255)")]
        public string NomeGrupo { get; set; }
        
        [Column("Holding", TypeName = "Varchar(255)")]
        public string Holding { get; set; }

        [ForeignKey("TipoHold")]
        [Column("TipoHold", TypeName = "Varchar(255)")]
        public string IdTipoHold { get; set; }

        public TipoHold TipoHold { get; set; }
    }   
}
