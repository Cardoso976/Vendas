using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vendas.Migrations;
using Vendas.Persistencia;

namespace Vendas.Models.Repositorio
{
    public class VendaRepositorio
    {
        private readonly VendaDbContext _db;

        public VendaRepositorio()
        {
            this._db = new VendaDbContext();
        }

        public Venda GetVenda(int id)
        {
            return _db.Vendas.Find(id);
        }

        public IQueryable<Venda> GetVendaQueryable(int id)
        {
            return _db.Vendas
                .Include(v => v.Cliente)
                .Where(x=> x.Id == id);
        }

        public List<Venda> GetVendas()
        {
            return _db.Vendas.Include(v => v.Cliente).ToList();
        }

        public void Cadastrar(Venda venda)
        {
            _db.Vendas.Add(venda);
            _db.SaveChanges();
        }

        public bool ExcluirVenda(int id)
        {
            bool ret;
            try
            {
                var venda = GetVenda(id);
                _db.Vendas.Remove(venda);
                _db.SaveChanges();
                ret = true;
            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        public int Salvar(Venda venda)
        {
            if (venda.Id == 0)
            {
                _db.Vendas.Add(venda);
            }
            else
            {
                var vend = GetVenda(venda.Id);
                vend.Cliente = venda.Cliente;
                vend.Data = venda.Data;
                vend.Status = venda.Status;
            }

            _db.SaveChanges();

            return venda.Id;
        }
    }
}