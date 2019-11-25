using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCrudNetFramework.Validators;

namespace TesteCrudNetFramework.Models
{
 
    [Validator(typeof(ManobristaValidator))]
    public class Manobrista : IModel
    {
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public Manobrista(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public Manobrista()
        {

        }
    }
}