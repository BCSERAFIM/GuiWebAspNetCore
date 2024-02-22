using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            // Include(obj => obj.Department) = Inclui o departamento
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove (int id)
        {
            // Pegar o objeto desejado (id)
            var obj = _context.Seller.Find(id);
            // Remover o objeto
            _context.Seller.Remove(obj);
            // Salvar as alterações feitas
            _context.SaveChanges();
        }


    }
}
