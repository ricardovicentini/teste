using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCrudNetFramework.Models;

namespace TesteCrudNetFramework.Repositorios
{
    interface ICrud<T> where T : IModel
    {
        void Adicionar(T model);
        void Excluir(T model);
        void Editar(T model);
        T Obter(object id);
        IEnumerable<T> Listar();
    }
}
