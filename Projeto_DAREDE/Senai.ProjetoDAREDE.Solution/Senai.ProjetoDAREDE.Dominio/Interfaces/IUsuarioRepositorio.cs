using Senai.ProjetoDAREDE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.ProjetoDAREDE.Dominio
{
    public interface IUsuarioRepositorio
    {
        UsuarioDominio EfetuaLogin(string email, string senha);

        List<UsuarioDominio> Listar();

        void Cadastrar(UsuarioDominio usuario);

    }
}
