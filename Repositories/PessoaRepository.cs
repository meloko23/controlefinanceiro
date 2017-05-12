using AppMvcControleFinanceiro.Context;
using AppMvcControleFinanceiro.Entities;

namespace AppMvcControleFinanceiro.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(ControleFinanceiroContext context) : base(context)
        {
            if (context == null)
            {
                context = Db;
            }
        }
    }
}
