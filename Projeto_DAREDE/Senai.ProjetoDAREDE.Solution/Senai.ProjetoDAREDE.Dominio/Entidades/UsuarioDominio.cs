using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.ProjetoDAREDE.Dominio.Entidades
{
    public class UsuarioDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Nome", TypeName = "Varchar(150)")]
        public string Nome { get; set; }

        [Required]
        [Column("Email", TypeName = "Varchar(150)")]
        public string Email { get; set; }

        [Required]
        [Column("Senha", TypeName = "Varchar(150)")]
        public string Senha { get; set; }

        [Required]
        [Column("Nome da Empresa", TypeName = "Varchar(200)")]
        public string NomeEmpresa { get; set; }

        // Estava em duvida de como definir se é string ou outra coisa, por ser select
        //[Required]
        //[Column("Tipo da Empresa", TypeName = "")]

        
        
        // Se for o Grupo de empresas continuar abaixo.
    
        [Required]
        [Column("Nome do Grupo", TypeName = "Varchar(200)")]
        public string NomeGrupo { get; set; }

        // ainda falta a parte do holding, por que eu não entendi direto de como fazer o holding.
    }   // e falta outra coluna especificando se e participante ou holding.
}
