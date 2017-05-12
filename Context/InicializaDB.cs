using System.Linq;
using AppMvcControleFinanceiro.Entities;

namespace AppMvcControleFinanceiro.Context
{
    public static class InicializaDB
	{
		public static void Inicialize(ControleFinanceiroContext context)
		{
			context.Database.EnsureCreated();

            if (context.Pessoas.Any())
			{
				return;
			}

			var pessoas = new Pessoa[]
			{
                new Pessoa { 
                    Nome = "Fernando José", 
                    Sobrenome = "Cordeiro", 
                    Cpf="99999999999", 
                    DataNascimento = new System.DateTime(1983,12,7), 
                    Email = "emailTeste1@gmail.com" 
                } ,
				new Pessoa {
					Nome = "Larissa",
					Sobrenome = "de Faria",
					Cpf="77777777777",
					DataNascimento = new System.DateTime(1985,11,20),
					Email = "emailTeste2@gmail.com"
				}
			};
			foreach (Pessoa pessoa in pessoas)
			{
                context.Pessoas.Add(pessoa);
			}
			context.SaveChanges();
		}
	}
}
