using Senai.ProjetoDAREDE.Dominio.Entidades;
using Senai.ProjetoDAREDE.Dominio.Interfaces;
using Senai.ProjetoDAREDE.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.ProjetoDAREDE.Infra.Data.Repositorios
{
    public class ServicosRepositorio : IServicosRepositorio
    {
        //Declara uma variável do tipo context
        private ProjetoDAREDEContext _context;

        //Utiliza injeção de dependencia.
        public ServicosRepositorio(ProjetoDAREDEContext context)
        {
            _context = context;
        }
        public void Atualizar(int Id, ServicosDominio servicos)
        {
            try
            {
                var Servicos = BuscarPorId(Id);
                Servicos.Id = servicos.Id;
                Servicos.Nome = servicos.Nome;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ServicosDominio BuscarPorId(int id)
        {
            try
            {
                // busca um pacote pelo id
                return _context.Servicos.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Cadastrar(ServicosDominio servicos)
        {
            try
            {
                _context.Servicos.Add(servicos);

                _context.SaveChanges();
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Deletar(int id, ServicosDominio servicos)
        {
            _context.Servicos.Remove(servicos);

            _context.SaveChanges();
        }

        public List<ServicosDominio> Listar()
        {
            try
            {
                return _context.Servicos.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
