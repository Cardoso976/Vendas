using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Cliente> GetClientes()
        {
            return _db.Clientes.ToList();
        }

        public void Cadastrar(Cliente cliente)
        {
            _db.Clientes.Add(cliente);
            _db.SaveChanges();
        }

        public bool ExcluirCliente(int id)
        {
            bool ret;
            try
            {
                var cliente = GetCliente(id);
                _db.Clientes.Remove(cliente);
                _db.SaveChanges();
                ret = true;
            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        public int Salvar(Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                _db.Clientes.Add(cliente);
            }
            else
            {
                var cli = GetCliente(cliente.Id);
                cli.Nome = cliente.Nome;
                cli.Email = cliente.Email;
            }

            _db.SaveChanges();

            return cliente.Id;
        }
    }
}