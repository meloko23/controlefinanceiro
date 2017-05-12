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
                    Sobrenome = "Silvestre de Faria Filho", 
                    Cpf="00241152151", 
                    DataNascimento = new System.DateTime(1983,11,2), 
                    Email = "meloko23@gmail.com" 
                } ,
				new Pessoa {
					Nome = "Larissa",
					Sobrenome = "de Lima Cordeiro de Faria",
					Cpf="01583680101",
					DataNascimento = new System.DateTime(1985,8,15),
					Email = "larissa.lima.cordeiro@gmail.com"
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
