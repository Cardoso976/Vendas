using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vendas.Persistencia;

namespace Vendas.Models
{
    public class ClienteRepositorio
    {
        private readonly VendaDbContext _db;

        public ClienteRepositorio()
        {
            this._db = new VendaDbContext();
        }

        public Cliente GetCliente(int id)
        {
            return _db.Clientes.Find(id);
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return _db.Clientes.ToList();
        }

        public void Cadastrar(Cliente cliente)
        {
            _db.Clientes.Add(cliente);
            _db.SaveChanges();
        }

        public void DeletarCliente(int id)
        {
            var cliente = GetCliente(id);
            _db.Clientes.Remove(cliente);
            _db.SaveChanges();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            var cli = GetCliente(cliente.Id);
            cli = cliente;
            _db.SaveChanges();
        }
    }
}