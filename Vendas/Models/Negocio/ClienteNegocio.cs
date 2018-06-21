using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendas.Models
{
    public class ClienteNegocio
    {
        private readonly ClienteRepositorio repositorio;

        public ClienteNegocio()
        {
            repositorio = new ClienteRepositorio();
        }

        public void Cadastrar(Cliente cliente)
        {
            repositorio.Cadastrar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            repositorio.AtualizarCliente(cliente);
        }

        public void Deletar(int id)
        {
            repositorio.DeletarCliente(id);
        }

        public Cliente GetCliente(int id)
        {
           return repositorio.GetCliente(id);
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return repositorio.GetClientes();
        }
    }
}