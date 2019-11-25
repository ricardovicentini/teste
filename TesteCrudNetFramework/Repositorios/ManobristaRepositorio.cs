using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCrudNetFramework.Models;
using TesteCrudNetFramework.TesteDBContext;

namespace TesteCrudNetFramework.Repositorios
{
    public class ManobristaRepositorio : ICrud<Manobrista>
    {
        private TesteCrudDBContext context;
        public ManobristaRepositorio(TesteCrudDBContext dbContext)
        {
            context = dbContext;

        }
        public void Adicionar(Manobrista model)
        {
            context.Manobristas.Add(model);
            context.SaveChanges();
        }

        public void Editar(Manobrista model)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Manobrista model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manobrista> Listar()
        {
            return  context.Manobristas;
        }

        public Manobrista Obter(object id)
        {
            throw new NotImplementedException();
        }
    }
}