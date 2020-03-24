using Senai.ProjetoDAREDE.Dominio;
using Senai.ProjetoDAREDE.Dominio.Entidades;
using Senai.ProjetoDAREDE.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.ProjetoDAREDE.Infra.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private ProjetoDAREDEContext ctx;


        public void Cadastrar(UsuarioDominio usuario)
        {
            try
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public UsuarioDominio EfetuaLogin(string email, string senha)
        {
            try
            {
                return ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UsuarioDominio> Listar()
        {
            try
            {
                return ctx.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
