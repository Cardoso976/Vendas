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

        public int SalvarCliente(Cliente cliente)
        {
            return repositorio.Salvar(cliente);
        }

        public bool Deletar(int id)
        {
           return repositorio.ExcluirCliente(id);
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