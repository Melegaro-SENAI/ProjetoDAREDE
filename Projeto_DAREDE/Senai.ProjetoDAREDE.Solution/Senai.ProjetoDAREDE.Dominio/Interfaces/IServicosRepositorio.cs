using Senai.ProjetoDAREDE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.ProjetoDAREDE.Dominio.Interfaces
{
    public interface IServicosRepositorio
    {
        List<ServicosDominio> Listar();

        void Cadastrar(ServicosDominio servicos);

        void Atualizar(int id, ServicosDominio servicos);

        void Deletar(int id, ServicosDominio servicos);

        ServicosDominio BuscarPorId(int id);
    }
}
